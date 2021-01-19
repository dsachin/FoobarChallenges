        public static int[] Answer(int[] input, int n)
        {
            int sum = 0, index = 0, finalIndex = 0, i = 0;
            while (i < input.Length)
            {
                if (sum < n)
                {
                    sum += input[i];
                    if (sum == n)
                    {
                        finalIndex = i;
                        break;
                    }
                    i++;
                }
                else
                {
                    i = index + 1;
                    index++;
                    sum = 0;
                }
                if (index != input.Length - 1 && sum > n)
                {
                    i--;
                }
            }

            if (sum == n && finalIndex != 0)
            {
                return new int[] { index, finalIndex };
            }
            else
            {
                return new int[] { -1, -1 };
            }
        }
