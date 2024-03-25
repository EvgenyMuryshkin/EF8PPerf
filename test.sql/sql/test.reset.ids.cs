// autogenerated by ServerDbGenerator
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable IDE0017 // Object Initialization
#pragma warning disable IDE0028 // Collection Initialization
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
#pragma warning disable CS0612 // Type or member is obsolete
using crosscutting;
using crosscutting.sql;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using crosscutting.cqrs;
namespace test.sql
{
	using test.sql;
public partial class tstT016CompositeChildRecordDbRecord
{
	public void ResetIds()
	{
		Id = 0;
	}
}
public partial class tstT015ChildL1RecordDbRecord
{
	public void ResetIds()
	{
		Id = 0;
	}
}
public partial class tstT015ChildL2RecordDbRecord
{
	public void ResetIds()
	{
		Id = 0;
	}
}
public partial class tstT015ChildOwnedRecordDbRecord
{
	public void ResetIds()
	{
		Id = 0;
	}
}
public partial class tstT015CompositeChildDbRecord
{
	public void ResetIds()
	{
		Id = 0;
	}
}
public partial class tstT015ParentOrderedRecordDbRecord
{
	public void ResetIds()
	{
		Id = 0;
		if (CompositeOderedChildren != null) CompositeOderedChildren.ForEach(r => r?.ResetIds());
	}
}
public partial class tstT015ParentRecordDbRecord
{
	public void ResetIds()
	{
		Id = 0;
		OptionalCompositeChild?.ResetIds();
		RequiredCompositeChild?.ResetIds();
		if (CompositeChildren != null) CompositeChildren.ForEach(r => r?.ResetIds());
	}
}
public partial class tstT016CompositeParentRecordDbRecord
{
	public void ResetIds()
	{
		Id = 0;
		if (Children != null) Children.ForEach(r => r?.ResetIds());
	}
}
}
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning restore IDE0028 // Collection Initialization
#pragma warning restore IDE0017 // Object Initialization
#pragma warning restore IDE1006 // Naming Styles
