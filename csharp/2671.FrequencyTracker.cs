// Design a data structure that keeps track of the values in it and answers some queries regarding their frequencies.

// Implement the FrequencyTracker class.

// FrequencyTracker(): Initializes the FrequencyTracker object with an empty array initially.
// void add(int number): Adds number to the data structure.
// void deleteOne(int number): Deletes one occurence of number from the data structure. The data structure may not contain number, and in this case nothing is deleted.
// bool hasFrequency(int frequency): Returns true if there is a number in the data structure that occurs frequency number of times, otherwise, it returns false.

public class FrequencyTracker {
    
    private Dictionary<int, int> _dict;
    private Dictionary<int, int> _freq;

    public FrequencyTracker()
    {
        _dict = new Dictionary<int, int>();
        _freq = new Dictionary<int, int>();
    }
    
    public void Add(int number) {
        
        if (_dict.ContainsKey(number))
        {
            if (_freq.ContainsKey(_dict[number]) && _freq[_dict[number]] > 0)
            {
                _freq[_dict[number]]--;
            }
            _dict[number]++;
        }
        else
        {
            _dict.Add(number, 1);
        }
        if (!_freq.ContainsKey(_dict[number]))
        {
            _freq.Add(_dict[number], 1);
        }
        else
        {
            _freq[_dict[number]]++;
        }
    }
    
    public void DeleteOne(int number) {
        
        if (_dict.ContainsKey(number) && _dict[number] > 0)
        {
            if (_freq.ContainsKey(_dict[number]) && _freq[_dict[number]] > 0)
            {
                _freq[_dict[number]]--;
            }
            _dict[number]--;
            if (_dict[number] != 0)
            {
               _freq[_dict[number]]++;
            }
        }
    }
    
    public bool HasFrequency(int frequency) {
        
        return _freq.ContainsKey(frequency) && _freq[frequency] > 0;
    }
}