# 如何使用
把 ```using SheepYhangCN.RandomExtension;``` 添加到你C#檔案的開頭

# References
```RandomX.Choose<T>(Random實例,value1,value2,value3...)``` => 隨機選擇value<br>
```RandomX.ChooseInList<T>(Random實例,[value1,value2,value3...])``` => 隨機選擇value<br>
```RandomX.FiftyFifty(Random實例)``` => true/false<br>
```RandomX.FiftyFifty<T>(Random實例,value1,value2)``` => 50%概率返回value1，50%概率返回value2<br>
```RandomX.Chance(Random實例,百分制概率)``` => 你輸入的概率返回true，否則返回false<br>
```RandomX.Chance<T>(Random實例,百分制概率,value1,value2,value3...)``` => 你輸入的概率返回true，否則從[value2,value3...]中隨機返回一個<br>
```RandomX.ChanceInList<T>(Random實例,百分制概率,value1,[value2,value3...])``` => 你輸入的概率返回true，否則從[value2,value3...]中隨機返回一個<br>
```RandomX.ChancePerItem<T>(Random實例,{[value1,百分制概率],[value2,百分制概率]...})``` => 從你輸入的概率來返回值