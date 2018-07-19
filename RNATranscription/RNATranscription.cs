using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string rna = "";
            foreach (char element in nucleotide)
            {
                if(element == 'G')
                {
                    rna += 'C';
                }
                else if (element == 'C')
                {
                    rna += 'G';

                }
                else if (element == 'T')
                {
                    rna += 'A';

                }
                else if (element == 'A')
                {
                    rna += 'U';

                }
            }
            return rna;

        }
    }
}
