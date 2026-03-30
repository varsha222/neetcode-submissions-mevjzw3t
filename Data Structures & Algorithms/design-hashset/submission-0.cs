public class MyHashSet {
    private List<int> data;
    public MyHashSet() {
        data = new List<int>();
    }
    
    public void Add(int key) {
        if(!data.Contains(key))
        {
            data.Add(key);
        }
    }
    
    public void Remove(int key) {
        if(data.Contains(key))
        {
            data.Remove(key);
        }
    }
    
    public bool Contains(int key) {
       return data.Contains(key); 
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */