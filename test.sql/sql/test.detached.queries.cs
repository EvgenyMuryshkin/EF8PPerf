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
	using test.model;
	using test.model;
// generated class, do not modify, source here: file:///placeholder
public partial class tstTestDBContext : EntityDbContext<tstTestDBContext>
{
	// back references of composites
	// tstCompositeChild
	public IQueryable<tstCompositeChildDbEntity> DetachedCompositeChildrenWithBackRefs => 
		CompositeChildren
			.Include(p => p.CompositeRefParents_Composite)
			.Include(p => p.CompositesContainer)
			.Include(p => p.MultipleCompositeRefs_Composite)
			.Include(p => p.MultipleCompositeRefs_OptionalComposite)
			.Include(p => p.NestedCompositeRoots_Composite)
			.Include(p => p.NestedCompositeRoots_OptionalComposite)
			.Include(p => p.NestedComposites)
			.Include(p => p.NestedComposites_Composite)
			.Include(p => p.OptionalCompositeRefParents_Composite)
			.Include(p => p.T001Children_CompositeChild)
			.Include(p => p.T008Parents_Child)
			.Include(p => p.T011CompositeRefParentContainer)
			.Include(p => p.T011CompositeRefParentContainers_CompositeChild)
			.Include(p => p.T012CompositeRefParentContainers_CompositeChild)
			.Include(p => p.T013CompositeRefParentContainer)
		;
	// ==============
	// tstNestedComposites
	public IQueryable<tstNestedCompositesDbEntity> DetachedNestedCompositesWithBackRefs => 
		NestedComposites
			.Include(p => p.NestedCompositeRoots_Nested)
		;
	// ==============
	// tstT009Composite
	public IQueryable<tstT009CompositeDbEntity> DetachedT009CompositesWithBackRefs => 
		T009Composites
			.Include(p => p.T009Principal)
			.Include(p => p.T009Principals_Composite)
		;
	// ==============
	// tstT011CompositeRefParentContainer
	public IQueryable<tstT011CompositeRefParentContainerDbEntity> DetachedT011CompositeRefParentContainersWithBackRefs => 
		T011CompositeRefParentContainers
			.Include(p => p.T011CompositeRefParents_Container)
		;
	// ==============
	// tstT012CompositeRefParentContainer
	public IQueryable<tstT012CompositeRefParentContainerDbEntity> DetachedT012CompositeRefParentContainersWithBackRefs => 
		T012CompositeRefParentContainers
			.Include(p => p.T012CompositeRefParents_Container)
		;
	// ==============
	// tstT013CompositeRefParentContainer
	public IQueryable<tstT013CompositeRefParentContainerDbEntity> DetachedT013CompositeRefParentContainersWithBackRefs => 
		T013CompositeRefParentContainers
			.Include(p => p.T013CompositeRefParents_Container)
		;
	// ==============
	// tstT010CompositeRefChild
	public IQueryable<tstT010CompositeRefChildDbEntity> DetachedT010CompositeRefChildrenWithBackRefs => 
		T010CompositeRefChildren
			.Include(p => p.T010CompositeRefParent)
			.Include(p => p.T010CompositeRefParents_T010CompositeRefChild)
		;
	// ==============
	// detached composites query
	// tstCompositeChild
	public IQueryable<tstCompositeChildDbEntity> DetachedCompositeChildrenWithComposites =>
		DetachedCompositeChildrenWithBackRefs
		.Where(e =>
			(e.CompositeRefParents_Composite == null || !e.CompositeRefParents_Composite.Any()) && 
			(e.CompositesContainerId == null) && 
			(e.MultipleCompositeRefs_Composite == null || !e.MultipleCompositeRefs_Composite.Any()) && 
			(e.MultipleCompositeRefs_OptionalComposite == null || !e.MultipleCompositeRefs_OptionalComposite.Any()) && 
			(e.NestedCompositeRoots_Composite == null || !e.NestedCompositeRoots_Composite.Any()) && 
			(e.NestedCompositeRoots_OptionalComposite == null || !e.NestedCompositeRoots_OptionalComposite.Any()) && 
			(e.NestedComposites_Composite == null || !e.NestedComposites_Composite.Any()) && 
			(e.NestedCompositesId == null) && 
			(e.OptionalCompositeRefParents_Composite == null || !e.OptionalCompositeRefParents_Composite.Any()) && 
			(e.T001Children_CompositeChild == null || !e.T001Children_CompositeChild.Any()) && 
			(e.T008Parents_Child == null || !e.T008Parents_Child.Any()) && 
			(e.T011CompositeRefParentContainers_CompositeChild == null || !e.T011CompositeRefParentContainers_CompositeChild.Any()) && 
			(e.T011CompositeRefParentContainerId == null) && 
			(e.T012CompositeRefParentContainers_CompositeChild == null || !e.T012CompositeRefParentContainers_CompositeChild.Any()) && 
			(e.T013CompositeRefParentContainerId == null)
		)
	;
	// tstNestedComposites
	public IQueryable<tstNestedCompositesDbEntity> DetachedNestedCompositesWithComposites =>
		DetachedNestedCompositesWithBackRefs
		.Where(e =>
			(e.NestedCompositeRoots_Nested == null || !e.NestedCompositeRoots_Nested.Any())
		)
	;
	// tstT009Composite
	public IQueryable<tstT009CompositeDbEntity> DetachedT009CompositesWithComposites =>
		DetachedT009CompositesWithBackRefs
		.Where(e =>
			(e.T009Principals_Composite == null || !e.T009Principals_Composite.Any()) && 
			(e.T009PrincipalId == null)
		)
	;
	// tstT010CompositeRefChild
	public IQueryable<tstT010CompositeRefChildDbEntity> DetachedT010CompositeRefChildrenWithComposites =>
		DetachedT010CompositeRefChildrenWithBackRefs
		.Where(e =>
			(e.T010CompositeRefParents_T010CompositeRefChild == null || !e.T010CompositeRefParents_T010CompositeRefChild.Any()) && 
			(e.T010CompositeRefParentId == null)
		)
	;
	// tstT011CompositeRefParentContainer
	public IQueryable<tstT011CompositeRefParentContainerDbEntity> DetachedT011CompositeRefParentContainersWithComposites =>
		DetachedT011CompositeRefParentContainersWithBackRefs
		.Where(e =>
			(e.T011CompositeRefParents_Container == null || !e.T011CompositeRefParents_Container.Any())
		)
	;
	// tstT012CompositeRefParentContainer
	public IQueryable<tstT012CompositeRefParentContainerDbEntity> DetachedT012CompositeRefParentContainersWithComposites =>
		DetachedT012CompositeRefParentContainersWithBackRefs
		.Where(e =>
			(e.T012CompositeRefParents_Container == null || !e.T012CompositeRefParents_Container.Any())
		)
	;
	// tstT013CompositeRefParentContainer
	public IQueryable<tstT013CompositeRefParentContainerDbEntity> DetachedT013CompositeRefParentContainersWithComposites =>
		DetachedT013CompositeRefParentContainersWithBackRefs
		.Where(e =>
			(e.T013CompositeRefParents_Container == null || !e.T013CompositeRefParents_Container.Any())
		)
	;
	public List<IDbEntity> DetachedComposites()
	{
		var result = new List<IDbEntity>();
		result.AddRange(DetachedCompositeChildrenWithComposites);
		result.AddRange(DetachedNestedCompositesWithComposites);
		result.AddRange(DetachedT009CompositesWithComposites);
		result.AddRange(DetachedT010CompositeRefChildrenWithComposites);
		result.AddRange(DetachedT011CompositeRefParentContainersWithComposites);
		result.AddRange(DetachedT012CompositeRefParentContainersWithComposites);
		result.AddRange(DetachedT013CompositeRefParentContainersWithComposites);
		return result;
	}
	public List<string> TableNames =>
		new List<string>()
		{
			"__EFMigrationsHistory",
			"owner_container_raw_raws",
			"shared_container_raw_shareds",
			"multiple_shared_container_raw_first_shareds",
			"multiple_shared_container_raw_second_shareds",
			"mixed_container_raw_owneds",
			"mixed_container_raw_shareds",
			"nested_composite_root_raw_raw_lists",
			"parent_child_children",
			"t001_parent_owner_t001_child_t001_children",
			"parent_with_shared_list_raw_raw_lists",
			"t002_parent_owner_t002_child_t002_children",
			"t003_parent_owner_t003_child_t003_children",
			"t004_recursive_link_set_t004_recursive_link_set_recursive_links",
			"t005_recursive_link_list_t005_recursive_link_list_recursive_links",
			"t007_leaf_t007_leaf_t007_leaves",
			"t007_root_t007_leaf_t007_leaves",
			"t015_parent_record_t015_child_l1_record_children",
			"t015_child_l1_record_t015_child_l2_record_children",
			"t015_parent_ordered_record_t015_child_owned_record_ordered_owned_children",
			"t015_parent_ordered_record_t015_child_l1_record_ordered_children",
			"raws",
			"required_shared_refs",
			"optional_shared_refs",
			"composite_ref_parents",
			"optional_composite_ref_parents",
			"owner_containers",
			"composites_containers",
			"shared_containers",
			"multiple_shared_containers",
			"mixed_containers",
			"multiple_composite_refs",
			"multiple_shared_refs",
			"nested_composite_roots",
			"children",
			"parents",
			"t001_children",
			"t001_parent_owners",
			"parent_with_shared_lists",
			"t002_children",
			"t002_parent_owners",
			"t002_child_holders",
			"t003_children",
			"t003_parent_owners",
			"t003_child_holders",
			"t004_recursive_link_sets",
			"t005_recursive_link_lists",
			"t006_perf_max_query_items",
			"t006_perf_max_query_values",
			"t007_leaves",
			"t007_roots",
			"t008_parents",
			"t009_principals",
			"t009_users",
			"t010_composite_ref_parents",
			"t011_composite_ref_parents",
			"t012_composite_ref_parents",
			"t013_composite_ref_parents",
			"t014_auto_create_values",
			"t015_parent_records",
			"t015_child_l1_records",
			"t015_child_l2_records",
			"t015_child_owned_records",
			"t015_parent_ordered_records",
			"t016_composite_parent_records",
			"composite_children",
			"nested_composites",
			"t009_composites",
			"t010_composite_ref_children",
			"t011_composite_ref_parent_containers",
			"t012_composite_ref_parent_containers",
			"t013_composite_ref_parent_containers",
			"t015_composite_children",
			"t016_composite_child_records",
		};
	public void DeleteDomainTables()
	{
		DropAllConstraints("tst");
		foreach (var table in TableNames)
		{
			var sql = $"DROP TABLE [tst].[{table}]";
#pragma warning disable EF1000 // Possible SQL injection vulnerability.
			Database.ExecuteSqlRaw(sql);
#pragma warning restore EF1000 // Possible SQL injection vulnerability.
		}
	}
}
}
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning restore IDE0028 // Collection Initialization
#pragma warning restore IDE0017 // Object Initialization
#pragma warning restore IDE1006 // Naming Styles
