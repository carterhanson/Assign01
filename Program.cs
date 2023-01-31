MyList train = new MyList();

train.Append(12);
train.Append(24);
train.Append(8);

train.PrePend(14);
train.Insert(20, 2);

Node node = train.RemoveFromBack();
Console.WriteLine("removed node:" + node.Data);

//train.RemoveFromFront();
train.Print();

