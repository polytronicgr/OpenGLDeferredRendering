﻿using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredLightRendering
{
    class GeomShader : Shader
    {
        public Matrix4 View
        {
            set { SetUniform("View", value); }
        }

        public Matrix4 Projection
        {
            set { SetUniform("Proj", value); }
        }

        public Matrix4 World
        {
            set { SetUniform("World", value); }
        }

        public Texture2D Texture
        {
            set { SetTextureUniform("Texture", value); }
        }

        static Dictionary<int,string> _data = new Dictionary<int,string>(){
            {0,"Position"},
            {1, "Tex"},
            {2, "Norm"}
        };

        public GeomShader(string data)
            : base(data + "DrawGeom.vs", data + "DrawGeom.fs", new ShaderInputLayout(_data))
        { 
        }
    }
}
