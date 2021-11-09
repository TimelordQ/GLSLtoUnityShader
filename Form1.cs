using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GLSLtoSHADER
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            resizeSplitter();
        }

        private void resizeSplitter()
        {
            this.txtGLSL.Width = mainSplitter.Panel1.Width;
            this.txtGLSL.Height = mainSplitter.Panel1.Height - 20;
            this.txtShaderOut.Width = mainSplitter.Panel2.Width - 10;
            this.txtShaderOut.Height = mainSplitter.Panel2.Height - 20;
        }
        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {
            resizeSplitter();
        }

        private void mainSplitter_SplitterMoved(object sender, SplitterEventArgs e)
        {
            resizeSplitter();
        }

        private void txtGLSL_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.F5)
            {
                string sTextFrom = this.txtGLSL.Text;
                string txtBeginning = File.ReadAllText("D:\\Experimental\\GLSLtoSHADER\\GLSLtoSHADER\\txtBeginning.txt");
                string txtEnding = File.ReadAllText("D:\\Experimental\\GLSLtoSHADER\\GLSLtoSHADER\\txtEnding.txt");
                string sProperties = ""; 

                sTextFrom = sTextFrom.Replace("void mainImage( out vec4 fragColor, in vec2 fragCoord )",
                                              "PLACEHOLDERFORMAIN");
                sTextFrom = sTextFrom.Replace("vec3", "float3");
                sTextFrom = sTextFrom.Replace("vec2", "float2");
                sTextFrom = sTextFrom.Replace("mat4", "float16");
                sTextFrom = sTextFrom.Replace("mat3", "float9");
                sTextFrom = sTextFrom.Replace("mat2", "float4");
                sTextFrom = sTextFrom.Replace("vec4", "float4");
                sTextFrom = sTextFrom.Replace("fract(", "frac(");
                sTextFrom = sTextFrom.Replace("\r\n", "\r\n            ");
                sTextFrom = sTextFrom.Replace("fragCoord", "i.uv");
                sTextFrom = sTextFrom.Replace("fragColor =", "return ");
                sTextFrom = sTextFrom.Replace("iTime", "_Time.y");
                sTextFrom = sTextFrom.Replace("texture(", "tex2D(");
                sTextFrom = sTextFrom.Replace("mix(", "lerp(");
                sTextFrom = sTextFrom.Replace("PLACEHOLDERFORMAIN", "fixed4 frag(v2f i) : SV_Target");


                if (sTextFrom.Contains("iChannel0"))
                {
                    sProperties += "_Channel0(\"iChannel0\", 2D) = \"black\" { }";
                    txtBeginning += "            #define iChannel0 _Channel0\r\n";
                    txtBeginning += "            sampler2D iChannel0;\r\n            ";
                }
                if (sTextFrom.Contains("iChannel1"))
                {
                    sProperties += sProperties.Length>0?"        ":"" + "_Channel1(\"iChannel1\", 2D) = \"black\" { }";
                    txtBeginning += "            #define iChannel1 _Channel1\r\n            ";
                    txtBeginning += "            sampler2D iChannel1;\r\n            ";
                }

                txtBeginning = txtBeginning.Replace("PROPERTIESPLACEHOLDER", (sProperties.Length > 0)?sProperties:"");

                string sTextAll = txtBeginning + sTextFrom + txtEnding;
                Clipboard.SetText(sTextAll);
                this.txtShaderOut.Text = sTextAll;
            }
        }
    }
}
