using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;

        public RoboInimigoAdapter(RoboInimigo novoRobo)
        {
            robo = novoRobo;
        }

        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.AndarParaFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}
