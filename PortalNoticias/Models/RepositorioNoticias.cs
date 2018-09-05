using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalNoticias.Models
{
    public static class RepositorioNoticias
    {
        private static List<Noticia> _noticias;

        public static List<Noticia> Noticias
        {
            get {
                    if (_noticias == null)
                        CriarNoticias();
                    return _noticias;
            }
        }

        private static void CriarNoticias()
        {
            _noticias = new List<Noticia>();

            _noticias.Add(new Noticia() {
                Id = 1,
                Titulo = "Palmeiras acerta venda de Keno para time do Egito por R$ 37 milhões",
                Autor = "Blog do Palmeiras",
                Data = DateTime.Today.Date,
                Conteudo = "Palmeiras acertou nesta segunda-feira a venda do atacante Keno. Depois de negociações nas últimas semanas, " +
                "o clube teve as exigências atendidas e definiu a transferência do atleta para o Al Ahram Pyramids FC, do Egito, " +
                "por US$ 10 milhões (cerca de R$ 37,8 milhões). O Verdão vai ficar com 100% do valor da transferência.O anúncio " +
                "foi feito pelo clube como o mais caro da história da liga egípcia"
            });
            _noticias.Add(new Noticia()
            {
                Id = 2,
                Titulo = "Torcida do Palmeiras comemora gol de Mina na Copa do Mundo; zagueiro manda abraço.",
                Autor = "Globo.com",
                Data = DateTime.Today,
                Conteudo = "Zagueiro Yerry Mina deixou o Palmeiras em janeiro deste ano. Mas, mesmo distante e vestindo a camisa " +
                "do Barcelona, o colombiano voltou a ser assunto entre os torcedores do Verdão neste domingo, quando ele marcou de " +
                "cabeça e abriu caminho para a vitória da Colômbia por 3 a 0 contra a Polônia, pela segunda rodada do Grupo H da Copa " +
                "do Mundo."
            });
            _noticias.Add(new Noticia()
            {
                Id = 3,
                Titulo = "Time sub-17 do Palmeiras aplica goleada de 17 a 0 no Paulistão da categoria",
                Autor = "Blog do Palmeiras",
                Data = DateTime.Today.Date.AddDays(1),
                Conteudo = "Time sub-17 do Palmeiras fez história no Campeonato Paulista ao, neste domingo, golear o São José " +
                "por 17 a 0, em partida válida pela 12ª rodada do torneio estadual da categoria. O jogo foi disputado no estádio " +
                "Novelli Junior, em Itu. Na quinta rodada da competição, os palmeirenses já haviam goleado a equipe de São José " +
                "dos Campos por 16 a 1.Os atacantes Fabricio, autor de sete gols, e Gabriel Silva, que marcou cinco vezes, foram " +
                "os destaques da vitória alviverde. Tatavitto, Victor Pires, Rondinely, Gabriel Veron e Geilson fecharam o placar " +
                "histórico."
            });
        }
    }
}