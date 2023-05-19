using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    //敵のステータス
    [System.Serializable]
    public struct EnemyStatuses
    {
        public string _enemyName;
        public float _enemyHP; 
        public float _enemyAtk;
        public float _enemySpeed;
        public float _enemySearchRange;
    }

    public List<EnemyStatuses> enemyStatuses = new List<EnemyStatuses>();
    private TextAsset csvText;
    List<string[]> csvData = new List<string[]>();
    //csvファイルから敵のステータスを入れ、リスト化する
    private void CsvReader()
    {
        csvText = Resources.Load<TextAsset>("EnemyData");
        
        StringReader reader = new StringReader(csvText.text);
        //1行ずつ読み、,で区切る
        while(reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            csvData.Add(line.Split(','));
        }
        //csvをリストに代入していく
        for(int i = 0; i < csvData.Count; i++)
        {
            EnemyStatuses eStatus;
            eStatus._enemyName = csvData[i][0];
                    eStatus._enemyHP = StringToFloat(csvData[i][1]);
                    eStatus._enemyAtk = StringToFloat(csvData[i][2]);
                    eStatus._enemySpeed = StringToFloat(csvData[i][3]);
                    eStatus._enemySearchRange = StringToFloat(csvData[i][4]);
            enemyStatuses.Add(eStatus);

        }
    }

    float StringToFloat(string num)
    {
        float n = float.Parse(num);
        return n;
    }
    // Start is called before the first frame update
    void Awake()
    {
        CsvReader();
    }

}
