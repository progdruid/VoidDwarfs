using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Registry
{
    private List<StructureData> datas;

    public int dataCount => datas.Count;
    public StructureData GetData (int _id)
    {
        try
        {
            return datas[_id];
        }
        catch
        {
            throw new System.Exception("No such structure data");
        }
    }
    public int GetDataID (StructureData _data)
    {
        try
        {
            return datas.IndexOf(_data);
        }
        catch { throw new System.Exception("No such structure data"); }
    }


    public void Init ()
    {
        InitDatas();
    }

    private void InitDatas ()
    {
        datas = new List<StructureData>();

        //0
        datas.Add(new StructureData (
            "Prop",
            1, 1, 
            Utilities.LoadSprite("Arts/Rock", 10), 
            new TraitData[] { new PropData(4.5f), new HealthData(20) }
            ));
        
        //1
        datas.Add(new StructureData(
            "Rock",
            1, 1,
            Utilities.LoadSprite("Arts/Rock", 10),
            new TraitData[] { new ExpanderData() }
            ));
    }
}
