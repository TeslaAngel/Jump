using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Params 
{
    private static Params instance = new Params();
    private bool isChange1 = false;
    private bool isChange2 = false;
    private bool isTongGuan = false;
    public static Params getInstans() {
        return instance;
    }
    public void setChange1(bool isChange1) {
        this.isChange1 = isChange1;
    }
    public bool getChange1() {
        return isChange1;
    }
    public void setChange2(bool isChange2)
    {
        this.isChange2 = isChange2;
    }
    public bool getChange2()
    {
        return isChange2;
    }
    public void setTongguan(bool istongguan)
    {
        this.isTongGuan = istongguan;
    }
    public bool getTongguan()
    {
        return isTongGuan;
    }
}
