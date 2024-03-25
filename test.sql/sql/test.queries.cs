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
	using Z.EntityFramework.Plus;
	using test.model;
// generated class, do not modify, source here: file:///placeholder
public partial class tstTestDBContext : EntityDbContext<tstTestDBContext>
{
	// local view queries
	public IEnumerable<tstRawDbEntity> RawsLocal => Raws.Local;
	public IEnumerable<tstRequiredSharedRefDbEntity> RequiredSharedRefsLocal => RequiredSharedRefs.Local;
	public IEnumerable<tstOptionalSharedRefDbEntity> OptionalSharedRefsLocal => OptionalSharedRefs.Local;
	public IEnumerable<tstCompositeRefParentDbEntity> CompositeRefParentsLocal => CompositeRefParents.Local;
	public IEnumerable<tstOptionalCompositeRefParentDbEntity> OptionalCompositeRefParentsLocal => OptionalCompositeRefParents.Local;
	public IEnumerable<tstOwnerContainerDbEntity> OwnerContainersLocal => OwnerContainers.Local;
	public IEnumerable<tstCompositesContainerDbEntity> CompositesContainersLocal => CompositesContainers.Local;
	public IEnumerable<tstSharedContainerDbEntity> SharedContainersLocal => SharedContainers.Local;
	public IEnumerable<tstMultipleSharedContainerDbEntity> MultipleSharedContainersLocal => MultipleSharedContainers.Local;
	public IEnumerable<tstMixedContainerDbEntity> MixedContainersLocal => MixedContainers.Local;
	public IEnumerable<tstMultipleCompositeRefDbEntity> MultipleCompositeRefsLocal => MultipleCompositeRefs.Local;
	public IEnumerable<tstMultipleSharedRefDbEntity> MultipleSharedRefsLocal => MultipleSharedRefs.Local;
	public IEnumerable<tstNestedCompositeRootDbEntity> NestedCompositeRootsLocal => NestedCompositeRoots.Local;
	public IEnumerable<tstChildDbEntity> ChildrenLocal => Children.Local;
	public IEnumerable<tstParentDbEntity> ParentsLocal => Parents.Local;
	public IEnumerable<tstT001ChildDbEntity> T001ChildrenLocal => T001Children.Local;
	public IEnumerable<tstT001ParentOwnerDbEntity> T001ParentOwnersLocal => T001ParentOwners.Local;
	public IEnumerable<tstParentWithSharedListDbEntity> ParentWithSharedListsLocal => ParentWithSharedLists.Local;
	public IEnumerable<tstT002ChildDbEntity> T002ChildrenLocal => T002Children.Local;
	public IEnumerable<tstT002ParentOwnerDbEntity> T002ParentOwnersLocal => T002ParentOwners.Local;
	public IEnumerable<tstT002ChildHolderDbEntity> T002ChildHoldersLocal => T002ChildHolders.Local;
	public IEnumerable<tstT003ChildDbEntity> T003ChildrenLocal => T003Children.Local;
	public IEnumerable<tstT003ParentOwnerDbEntity> T003ParentOwnersLocal => T003ParentOwners.Local;
	public IEnumerable<tstT003ChildHolderDbEntity> T003ChildHoldersLocal => T003ChildHolders.Local;
	public IEnumerable<tstT004RecursiveLinkSetDbEntity> T004RecursiveLinkSetsLocal => T004RecursiveLinkSets.Local;
	public IEnumerable<tstT005RecursiveLinkListDbEntity> T005RecursiveLinkListsLocal => T005RecursiveLinkLists.Local;
	public IEnumerable<tstT006PerfMaxQueryItemDbEntity> T006PerfMaxQueryItemsLocal => T006PerfMaxQueryItems.Local;
	public IEnumerable<tstT006PerfMaxQueryValueDbEntity> T006PerfMaxQueryValuesLocal => T006PerfMaxQueryValues.Local;
	public IEnumerable<tstT007LeafDbEntity> T007LeavesLocal => T007Leaves.Local;
	public IEnumerable<tstT007RootDbEntity> T007RootsLocal => T007Roots.Local;
	public IEnumerable<tstT008ParentDbEntity> T008ParentsLocal => T008Parents.Local;
	public IEnumerable<tstT009PrincipalDbEntity> T009PrincipalsLocal => T009Principals.Local;
	public IEnumerable<tstT009UserDbEntity> T009UsersLocal => T009Users.Local;
	public IEnumerable<tstT010CompositeRefParentDbEntity> T010CompositeRefParentsLocal => T010CompositeRefParents.Local;
	public IEnumerable<tstT011CompositeRefParentDbEntity> T011CompositeRefParentsLocal => T011CompositeRefParents.Local;
	public IEnumerable<tstT012CompositeRefParentDbEntity> T012CompositeRefParentsLocal => T012CompositeRefParents.Local;
	public IEnumerable<tstT013CompositeRefParentDbEntity> T013CompositeRefParentsLocal => T013CompositeRefParents.Local;
	public IEnumerable<tstT014AutoCreateValueDbEntity> T014AutoCreateValuesLocal => T014AutoCreateValues.Local;
	public IEnumerable<tstT015ParentRecordDbRecord> T015ParentRecordsLocal => T015ParentRecords.Local;
	public IEnumerable<tstT015ChildL1RecordDbRecord> T015ChildL1RecordsLocal => T015ChildL1Records.Local;
	public IEnumerable<tstT015ChildL2RecordDbRecord> T015ChildL2RecordsLocal => T015ChildL2Records.Local;
	public IEnumerable<tstT015ChildOwnedRecordDbRecord> T015ChildOwnedRecordsLocal => T015ChildOwnedRecords.Local;
	public IEnumerable<tstT015ParentOrderedRecordDbRecord> T015ParentOrderedRecordsLocal => T015ParentOrderedRecords.Local;
	public IEnumerable<tstT016CompositeParentRecordDbRecord> T016CompositeParentRecordsLocal => T016CompositeParentRecords.Local;
	// top-level queries with composites
	public IQueryable<tstRawDbEntity> RawsWithComposites =>
		Raws
		;
	public IQueryable<tstRequiredSharedRefDbEntity> RequiredSharedRefsWithComposites =>
		RequiredSharedRefs
		;
	public IQueryable<tstOptionalSharedRefDbEntity> OptionalSharedRefsWithComposites =>
		OptionalSharedRefs
		;
	public IQueryable<tstCompositeRefParentDbEntity> CompositeRefParentsWithComposites =>
		CompositeRefParents
			.Include(c => c.Composite)
		;
	public IQueryable<tstOptionalCompositeRefParentDbEntity> OptionalCompositeRefParentsWithComposites =>
		OptionalCompositeRefParents
			.Include(c => c.Composite)
		;
	public IQueryable<tstOwnerContainerDbEntity> OwnerContainersWithComposites =>
		OwnerContainers
			.Include(c => c.Raws)
			.AsSplitQuery()
		;
	public IQueryable<tstCompositesContainerDbEntity> CompositesContainersWithComposites =>
		CompositesContainers
			.Include(c => c.Composites)
			.AsSplitQuery()
		;
	public IQueryable<tstSharedContainerDbEntity> SharedContainersWithComposites =>
		SharedContainers
			.Include(c => c.Shareds)
			.AsSplitQuery()
		;
	public IQueryable<tstMultipleSharedContainerDbEntity> MultipleSharedContainersWithComposites =>
		MultipleSharedContainers
			.Include(c => c.FirstShareds)
			.Include(c => c.SecondShareds)
			.AsSplitQuery()
		;
	public IQueryable<tstMixedContainerDbEntity> MixedContainersWithComposites =>
		MixedContainers
			.Include(c => c.Owneds)
			.Include(c => c.Shareds)
			.AsSplitQuery()
		;
	public IQueryable<tstMultipleCompositeRefDbEntity> MultipleCompositeRefsWithComposites =>
		MultipleCompositeRefs
			.Include(c => c.Composite)
			.Include(c => c.OptionalComposite)
		;
	public IQueryable<tstMultipleSharedRefDbEntity> MultipleSharedRefsWithComposites =>
		MultipleSharedRefs
		;
	public IQueryable<tstNestedCompositeRootDbEntity> NestedCompositeRootsWithComposites =>
		NestedCompositeRoots
			.Include(c => c.Composite)
			.Include(c => c.Nested).ThenInclude(c => c.Children)
			.Include(c => c.Nested).ThenInclude(c => c.Composite)
			.Include(c => c.OptionalComposite)
			.Include(c => c.RawLists)
			.AsSplitQuery()
		;
	public IQueryable<tstChildDbEntity> ChildrenWithComposites =>
		Children
		;
	public IQueryable<tstParentDbEntity> ParentsWithComposites =>
		Parents
			.Include(c => c.Children)
			.AsSplitQuery()
		;
	public IQueryable<tstT001ChildDbEntity> T001ChildrenWithComposites =>
		T001Children
			.Include(c => c.CompositeChild)
		;
	public IQueryable<tstT001ParentOwnerDbEntity> T001ParentOwnersWithComposites =>
		T001ParentOwners
			.Include(c => c.T001Children)
			.AsSplitQuery()
		;
	public IQueryable<tstParentWithSharedListDbEntity> ParentWithSharedListsWithComposites =>
		ParentWithSharedLists
			.Include(c => c.RawLists)
			.AsSplitQuery()
		;
	public IQueryable<tstT002ChildDbEntity> T002ChildrenWithComposites =>
		T002Children
		;
	public IQueryable<tstT002ParentOwnerDbEntity> T002ParentOwnersWithComposites =>
		T002ParentOwners
			.Include(c => c.T002Children)
			.AsSplitQuery()
		;
	public IQueryable<tstT002ChildHolderDbEntity> T002ChildHoldersWithComposites =>
		T002ChildHolders
		;
	public IQueryable<tstT003ChildDbEntity> T003ChildrenWithComposites =>
		T003Children
		;
	public IQueryable<tstT003ParentOwnerDbEntity> T003ParentOwnersWithComposites =>
		T003ParentOwners
			.Include(c => c.T003Children)
			.AsSplitQuery()
		;
	public IQueryable<tstT003ChildHolderDbEntity> T003ChildHoldersWithComposites =>
		T003ChildHolders
		;
	public IQueryable<tstT004RecursiveLinkSetDbEntity> T004RecursiveLinkSetsWithComposites =>
		T004RecursiveLinkSets
			.Include(c => c.RecursiveLinks)
			.AsSplitQuery()
		;
	public IQueryable<tstT005RecursiveLinkListDbEntity> T005RecursiveLinkListsWithComposites =>
		T005RecursiveLinkLists
			.Include(c => c.RecursiveLinks)
			.AsSplitQuery()
		;
	public IQueryable<tstT006PerfMaxQueryItemDbEntity> T006PerfMaxQueryItemsWithComposites =>
		T006PerfMaxQueryItems
		;
	public IQueryable<tstT006PerfMaxQueryValueDbEntity> T006PerfMaxQueryValuesWithComposites =>
		T006PerfMaxQueryValues
		;
	public IQueryable<tstT007LeafDbEntity> T007LeavesWithComposites =>
		T007Leaves
			.Include(c => c.T007Leaves)
			.AsSplitQuery()
		;
	public IQueryable<tstT007RootDbEntity> T007RootsWithComposites =>
		T007Roots
			.Include(c => c.T007Leaves)
			.AsSplitQuery()
		;
	public IQueryable<tstT008ParentDbEntity> T008ParentsWithComposites =>
		T008Parents
			.Include(c => c.Child)
		;
	public IQueryable<tstT009PrincipalDbEntity> T009PrincipalsWithComposites =>
		T009Principals
			.Include(c => c.Composite)
			.Include(c => c.T009Composites)
			.AsSplitQuery()
		;
	public IQueryable<tstT009UserDbEntity> T009UsersWithComposites =>
		T009Users
		;
	public IQueryable<tstT010CompositeRefParentDbEntity> T010CompositeRefParentsWithComposites =>
		T010CompositeRefParents
			.Include(c => c.T010CompositeRefChild)
			.Include(c => c.T010CompositeRefChildren)
			.AsSplitQuery()
		;
	public IQueryable<tstT011CompositeRefParentDbEntity> T011CompositeRefParentsWithComposites =>
		T011CompositeRefParents
			.Include(c => c.Container).ThenInclude(c => c.CompositeChild)
			.Include(c => c.Container).ThenInclude(c => c.CompositeChildren)
			.AsSplitQuery()
		;
	public IQueryable<tstT012CompositeRefParentDbEntity> T012CompositeRefParentsWithComposites =>
		T012CompositeRefParents
			.Include(c => c.Container).ThenInclude(c => c.CompositeChild)
		;
	public IQueryable<tstT013CompositeRefParentDbEntity> T013CompositeRefParentsWithComposites =>
		T013CompositeRefParents
			.Include(c => c.Container).ThenInclude(c => c.CompositeChildren)
			.AsSplitQuery()
		;
	public IQueryable<tstT014AutoCreateValueDbEntity> T014AutoCreateValuesWithComposites =>
		T014AutoCreateValues
		;
	public IQueryable<tstT015ParentRecordDbRecord> T015ParentRecordsWithComposites =>
		T015ParentRecords
			.Include(c => c.Children)
			.Include(c => c.CompositeChildren)
			.Include(c => c.OptionalCompositeChild)
			.Include(c => c.RequiredCompositeChild)
		;
	public IQueryable<tstT015ChildL1RecordDbRecord> T015ChildL1RecordsWithComposites =>
		T015ChildL1Records
			.Include(c => c.Children)
		;
	public IQueryable<tstT015ChildL2RecordDbRecord> T015ChildL2RecordsWithComposites =>
		T015ChildL2Records
		;
	public IQueryable<tstT015ChildOwnedRecordDbRecord> T015ChildOwnedRecordsWithComposites =>
		T015ChildOwnedRecords
		;
	public IQueryable<tstT015ParentOrderedRecordDbRecord> T015ParentOrderedRecordsWithComposites =>
		T015ParentOrderedRecords
			.Include(c => c.CompositeOderedChildren)
			.Include(c => c.OrderedChildren)
			.Include(c => c.OrderedOwnedChildren)
		;
	public IQueryable<tstT016CompositeParentRecordDbRecord> T016CompositeParentRecordsWithComposites =>
		T016CompositeParentRecords
			.Include(c => c.Children)
		;
}
}
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning restore IDE0028 // Collection Initialization
#pragma warning restore IDE0017 // Object Initialization
#pragma warning restore IDE1006 // Naming Styles