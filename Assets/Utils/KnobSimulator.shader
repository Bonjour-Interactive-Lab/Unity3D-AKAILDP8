Shader "Unlit/KnobSimulator"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Knob("Knob Value", Range(0, 1)) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _Knob;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            float map(float value, float min1, float max1, float min2, float max2) {
                return min2 + (value - min1) * (max2 - min2) / (max1 - min1);
            }

            #define PI 3.1415926538
            #define TWOPI 6.2831853076

            /**
            This function will return a 2d rotation matrix form the desired rectangle
            Learn more about rotation matrix : https://en.wikipedia.org/wiki/Rotation_matrix
            */
            float2x2 rotate2d(float angle){
            return float2x2(  cos(angle), -sin(angle),
                                sin(angle),  cos(angle));
            }

            /**
            this function will rotate the fragment coordinate at a desired angle from the center
            */
            float2 rotate(float2 st, float angle){
                float2x2 mat = rotate2d(angle);
                st = mul(mat, st);

                return st;
            }


            fixed4 frag (v2f i) : SV_Target
            {
                float2 uv       = i.uv * 2.0 -  1.0;
                // float value = frac(_Time.y * .1);
                float angle = lerp(PI * .75, PI * 2.25, _Knob);
                uv = rotate(uv, angle);// + value * TWOPI);

                float  circ     = length(uv) - 0.9;
                float  circMask = 1.0 - smoothstep(0, 0.05, circ);
                
                float circThickness = 0.001;
                float circSmoothness = 0.05;
                float  circStroke = smoothstep(circThickness * -.5 - circSmoothness, circThickness * -.5, circ) * (1.0 - smoothstep(circThickness * .5, circThickness * 0.5 + circSmoothness, circ));
                
                float thickness = 0.05;
                float liner = smoothstep(thickness * -0.5 - 0.05, thickness * -0.5, uv.y) * (1.0 - smoothstep(thickness * 0.5, thickness * 0.5 + 0.05, uv.y)) * step(0, uv.x);
                
                
                float3 color;
                color.rgb = circMask * liner + circStroke;
                return fixed4(color, 1);
            }
            ENDCG
        }
    }
}
