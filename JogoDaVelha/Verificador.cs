using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    public static class Verificador
    {
        public static int Linhas(int[,] mat)
        {
            for (int i = 0 ; i < 3; i++){
                if(mat[i,0] == 1 && mat[i,1] == 1 && mat[i,2] == 1)
                {
                    return 1;
                }
                else if(mat[i,0] == -1 && mat[i,1] == -1 && mat[i,2] == -1)
                {
                    return -1;
                }
            }
            return 0;
        }

        public static int Colunas(int[,] mat)
        {
            for(int j = 0; j < 3; j++)
            {
                if(mat[0,j] == 1 && mat[1,j] == 1 && mat[2,j] == 1)
                {
                    return 1;
                }
                else if(mat[0,j] == -1 && mat[1,j] == -1 && mat[2,j] == -1)
                {
                    return -1;
                }
            }
            return 0;
        }

        public static int DiagonalPrincipal(int[,] mat)
        {
            if(mat[0,0] == 1 && mat[1,1] == 1 && mat[2,2] == 1)
            {
                return 1;
            }
            else if(mat[0,0] == -1 && mat[1,1] == -1 && mat[2, 2] == -1)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static int DiagonalSecundaria(int[,] mat)
        {
            if(mat[2,0] == 1 && mat[1,1] == 1 && mat[0,2] == 1)
            {
                return 1;
            }
            else if(mat[2,0] == -1 && mat[1,1] == -1 && mat[0,2] == -1)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static int Geral(int[,] mat)
        {
            if(Linhas(mat) == 1)
            {
                return 1;
            }
            else if(Linhas(mat) == -1)
            {
                return -1;
            }
            else if(Colunas(mat) == 1 )
            {
                return 1;
            }
            else if(Colunas(mat) == -1)
            {
                return -1;
            }
            else if(DiagonalPrincipal(mat) == 1)
            {
                return 1;
            }
            else if(DiagonalPrincipal(mat) == -1)
            {
                return -1;
            }
            else if(DiagonalSecundaria(mat) == 1)
            {
                return 1;
            }
            else if(DiagonalSecundaria(mat) == -1)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
