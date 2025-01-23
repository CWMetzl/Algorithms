// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Result: [{0}]", Search.BinarySearch(new int[]{2},-2));
//Console.WriteLine("Result: [{0}]", Search.SearchInsert(new int[]{-1,3,5,6},0));
//Console.WriteLine("MaxArea: [{0}]", Area.MaxArea(new int[]{-1,3,5,6}));
//var rotate = new int[] {-1,-100,3,99};
//ArrayOperations.Rotate(rotate, 2);
//var rotate = new int[]{1,2,3,4,5,6,7};
//ArrayOperations.Rotate(rotate, 3);
//Console.WriteLine("Rotated: [{0}]",string.Join(',',rotate));
// var plain = "Zebra-493?";
// Console.WriteLine("Plaintext: {0}, Cipher: {1}", plain, Cipher.RotationalCipher(plain, 3));
// plain = "abcdefghijklmNOPQRSTUVWXYZ0123456789";
// Console.WriteLine("Plaintext: {0}, Cipher: {1}", plain, Cipher.RotationalCipher(plain, 39));
//var input = new long[]{2,6};
//Console.WriteLine("Seats: {0}, Spacing: {1}, Existing Diners: {2}, Seated: {3}, Additional: {4}",
//10, 1, 2, string.Join(',', input), Diner.getMaxAdditionalDinersCount(10,1,2,input));
//var input = new long[]{11,6,14};
//Console.WriteLine("Seats: {0}, Spacing: {1}, Existing Diners: {2}, Seated: {3}, Additional: {4}",
//15, 2, 3, string.Join(',', input), Diner.getMaxAdditionalDinersCount(15,2,3,input));
//var input = new long[]{1,8};
//Console.WriteLine("Seats: {0}, Spacing: {1}, Existing Diners: {2}, Seated: {3}, Additional: {4}",
//10, 1, 2, string.Join(',', input), Diner.getMaxAdditionalDinersCount(10,1,2,input));
//var input = new long[]{1,8};
//Console.WriteLine("Seats: {0}, Spacing: {1}, Existing Diners: {2}, Seated: {3}, Additional: {4}",
//(long)Math.Pow(10,15), 1, 2, string.Join(',', input), Diner.getMaxAdditionalDinersCount((long)Math.Pow(10,15),1,2,input));
// var input = new long[]{2,6};
// Console.WriteLine("Seats: {0}, Spacing: {1}, Existing Diners: {2}, Seated: {3}, Additional: {4}",
// (long)10, 1, 2, string.Join(',', input), Diner.getMaxAdditionalDinersCount((long)10,1,2,input));
//Console.WriteLine("{0}", Photography.getArtisticPhotographCount(8, ".PBAAP.B",1, 3));
//Console.WriteLine("{0}", Kaitenzushi.getMaximumEatenDishCount(6, new int[]{1,2,3,3,2,1},2));
//var array = new int[]{1,10,20,0,59,63,0,88,0};
//Console.WriteLine("Original: {0}, Shifted:{1}", string.Join(',',array), string.Join(',', ArrayOperations.MoveZeroesToLeft(array)));
//Console.WriteLine("DFT Array: {0}", string.Join(',',Trees.TestDFT()));
//Console.WriteLine("DFT Array Recursive: {0}", string.Join(',',Trees.TestDFTRecursive()));
//Console.WriteLine("BFT Array: {0}", string.Join(',',Trees.TestBFT()));
//Console.WriteLine("BFT Array Recursive: {0}", string.Join(',',Trees.TestBFT()));
//Console.WriteLine("Sum of Tree: {0}", Trees.TestSumTree());
//Console.WriteLine("Sum of Tree Recursive: {0}", Trees.TestTreeSumValueRecursive());
// Console.WriteLine("Tree Least Value: {0}", Trees.TestTreeLeastValue());
// Console.WriteLine("Tree Least Value Recursive: {0}", Trees.TestTreeLeastValueRecursive());
// Console.WriteLine("Tree Max Value: {0}", Trees.TestTreeLargestValue());
// Console.WriteLine("Tree Max Value Recursive: {0}", Trees.TestTreeLargestValueRecursive());
var tree = new BinarySearchTree<int>(new int[]{1,2,3,6,9,15,26});
tree.InsertValue(4);
var treeRoot = tree.Root;
//Console.WriteLine("Sorted Tree After Insert");
//Console.WriteLine(treeRoot != null ? treeRoot.DisplayNode() : string.Empty);
Console.WriteLine("Sorted Tree After Insert: {0}",string.Join(',', Trees.DepthFirstTraversalRecursive(tree.Root)));