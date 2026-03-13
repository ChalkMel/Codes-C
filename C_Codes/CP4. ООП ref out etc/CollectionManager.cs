namespace CP4._ООП_ref_out_etc;

public class CollectionManager
{
  private List<Artifact> _artifacts = new List<Artifact>();
  
  public Artifact[] Artifacts => _artifacts.ToArray();
  
  public bool AddArtifact(Artifact? artifact)
  {
    if (artifact == null)
      return false;
    
    if (_artifacts.Any(a => a.Name.Equals(artifact.Name)))
    {
      return false;
    }

    _artifacts.Add(artifact);
    return true;
  }
  
  public bool RemoveArtifact(string name)
  {
    if (string.IsNullOrEmpty(name))
      return false;
    
    bool removed = false;
    foreach (var art in _artifacts.ToList())
    {
      if (art.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
      {
        _artifacts.Remove(art);
        removed = true;
      }
    }
    return removed;
  }
  
  public void RemoveAt(int index)
  {
    if (index >= 0 && index < _artifacts.Count)
    {
      _artifacts.RemoveAt(index);
    }
    else
    {
      Console.WriteLine("Invalid index");
    }
  }
  
  public T[] GetArtifactsByType<T>() where T : Artifact
  {
    return _artifacts.OfType<T>().ToArray();
  }
}
