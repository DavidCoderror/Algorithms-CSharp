void triInsertion(int[] tab)
{
    int n = tab.Length;
    for (int i = 1; i < n; i++)
    {
        int elementCle = tab[i];
        int j = i;
        while (j > 0 && tab[j - 1] > elementCle)
        {
            tab[j] = tab[j - 1];
            j--;
        }
        tab[j] = elementCle;
    }
}

void triShell(int[] tab)
{
    int[] intervals = new int[] { 1750, 710, 301, 132, 57, 23, 10, 4, 1 };
    foreach (int interval in intervals)
    {
        triInsertionInterval(tab, interval);
    }
}

void triInsertionInterval(int[] tab, int interval)
{
    int n = tab.Length;
    for (int i = interval; i < n; i++)
    {
        int elementCle = tab[i];
        int j = i - interval;
        while (j >= 0 && tab[j] > elementCle)
        {
            tab[j + interval] = tab[j];
            j -= interval;
        }
        tab[j + interval] = elementCle;
    }
}
