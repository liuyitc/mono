// cs1528.cs: Expected ; or = (cannot specify constructor arguments in declaration)
// Line: 13

class X {
	X (int a)
	{
	}
}

class Y {
	static void Main ()
	{
		X x (4);
	}
}
