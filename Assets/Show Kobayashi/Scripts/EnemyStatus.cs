using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    //�G�̃X�e�[�^�X
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
    //csv�t�@�C������G�̃X�e�[�^�X�����A���X�g������
    private void CsvReader()
    {
        csvText = Resources.Load<TextAsset>("EnemyData");
        
        StringReader reader = new StringReader(csvText.text);
        //1�s���ǂ݁A,�ŋ�؂�
        while(reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            csvData.Add(line.Split(','));
        }
        //csv�����X�g�ɑ�����Ă���
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
