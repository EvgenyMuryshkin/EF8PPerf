using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.sql.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tst");

            migrationBuilder.CreateTable(
                name: "composites_containers",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    index = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_composites_containers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mixed_containers",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mixed_containers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "multiple_shared_containers",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multiple_shared_containers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "owner_containers",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    index = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner_containers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parent_with_shared_lists",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parent_with_shared_lists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parents",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "raws",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    index = table.Column<int>(type: "int", nullable: false),
                    date_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raws", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "shared_containers",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shared_containers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t001_parent_owners",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t001_parent_owners", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t002_children",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t002_children", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t002_parent_owners",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iteration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t002_parent_owners", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t003_children",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t003_children", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t003_parent_owners",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iteration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t003_parent_owners", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t004_recursive_link_sets",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t004_recursive_link_sets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t005_recursive_link_lists",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t005_recursive_link_lists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t006_perf_max_query_items",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t006_perf_max_query_items", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t006_perf_max_query_values",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t006_perf_max_query_values", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t007_leaves",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t007_leaves", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t007_roots",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t007_roots", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t013_composite_ref_parent_containers",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t013_composite_ref_parent_containers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t015_child_l2_records",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    child_l2_value = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_child_l2_records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t015_child_owned_records",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    child_l2_value = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_child_owned_records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t015_parent_ordered_records",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    parent_value = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_parent_ordered_records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t016_composite_parent_records",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    parent_value = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t016_composite_parent_records", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "children",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    second_parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_children", x => x.id);
                    table.ForeignKey(
                        name: "FK_children_parents_second_parent_id",
                        column: x => x.second_parent_id,
                        principalSchema: "tst",
                        principalTable: "parents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mixed_container_raw_owneds",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mixed_container_raw_owneds", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_mixed_container_raw_owneds_mixed_containers_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "mixed_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mixed_container_raw_owneds_raws_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mixed_container_raw_shareds",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mixed_container_raw_shareds", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_mixed_container_raw_shareds_mixed_containers_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "mixed_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mixed_container_raw_shareds_raws_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "multiple_shared_container_raw_first_shareds",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multiple_shared_container_raw_first_shareds", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_multiple_shared_container_raw_first_shareds_multiple_shared_containers_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "multiple_shared_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_multiple_shared_container_raw_first_shareds_raws_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "multiple_shared_container_raw_second_shareds",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multiple_shared_container_raw_second_shareds", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_multiple_shared_container_raw_second_shareds_multiple_shared_containers_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "multiple_shared_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_multiple_shared_container_raw_second_shareds_raws_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "multiple_shared_refs",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    raw_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    optional_raw_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multiple_shared_refs", x => x.id);
                    table.ForeignKey(
                        name: "FK_multiple_shared_refs_raws_optional_raw_id",
                        column: x => x.optional_raw_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_multiple_shared_refs_raws_raw_id",
                        column: x => x.raw_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "optional_shared_refs",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    value = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    raw_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_optional_shared_refs", x => x.id);
                    table.ForeignKey(
                        name: "FK_optional_shared_refs_raws_raw_id",
                        column: x => x.raw_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "owner_container_raw_raws",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owner_container_raw_raws", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_owner_container_raw_raws_owner_containers_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "owner_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_owner_container_raw_raws_raws_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "parent_with_shared_list_raw_raw_lists",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parent_with_shared_list_raw_raw_lists", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_parent_with_shared_list_raw_raw_lists_parent_with_shared_lists_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "parent_with_shared_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_parent_with_shared_list_raw_raw_lists_raws_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "required_shared_refs",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    value = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    raw_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_required_shared_refs", x => x.id);
                    table.ForeignKey(
                        name: "FK_required_shared_refs_raws_raw_id",
                        column: x => x.raw_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t014_auto_create_values",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reference_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValue: new Guid("f5871072-975e-415b-bf5c-11a81c1964d1")),
                    boolean_value1 = table.Column<bool>(type: "bit", nullable: false),
                    boolean_value2 = table.Column<bool>(type: "bit", nullable: false),
                    int_value = table.Column<int>(type: "int", nullable: false, defaultValue: 42),
                    decimal_value = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, defaultValue: 42m),
                    enum_value = table.Column<int>(type: "int", nullable: false, defaultValue: 10)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t014_auto_create_values", x => x.id);
                    table.ForeignKey(
                        name: "FK_t014_auto_create_values_raws_reference_id",
                        column: x => x.reference_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "shared_container_raw_shareds",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shared_container_raw_shareds", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_shared_container_raw_shareds_raws_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_shared_container_raw_shareds_shared_containers_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "shared_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t002_child_holders",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iteration = table.Column<int>(type: "int", nullable: false),
                    t002_child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t002_child_holders", x => x.id);
                    table.ForeignKey(
                        name: "FK_t002_child_holders_t002_children_t002_child_id",
                        column: x => x.t002_child_id,
                        principalSchema: "tst",
                        principalTable: "t002_children",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "t002_parent_owner_t002_child_t002_children",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t002_parent_owner_t002_child_t002_children", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t002_parent_owner_t002_child_t002_children_t002_children_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t002_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t002_parent_owner_t002_child_t002_children_t002_parent_owners_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t002_parent_owners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t003_child_holders",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    iteration = table.Column<int>(type: "int", nullable: false),
                    t003_child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t003_child_holders", x => x.id);
                    table.ForeignKey(
                        name: "FK_t003_child_holders_t003_children_t003_child_id",
                        column: x => x.t003_child_id,
                        principalSchema: "tst",
                        principalTable: "t003_children",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "t003_parent_owner_t003_child_t003_children",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t003_parent_owner_t003_child_t003_children", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t003_parent_owner_t003_child_t003_children_t003_children_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t003_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t003_parent_owner_t003_child_t003_children_t003_parent_owners_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t003_parent_owners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t004_recursive_link_set_t004_recursive_link_set_recursive_links",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t004_recursive_link_set_t004_recursive_link_set_recursive_links", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t004_recursive_link_set_t004_recursive_link_set_recursive_links_t004_recursive_link_sets_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t004_recursive_link_sets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t004_recursive_link_set_t004_recursive_link_set_recursive_links_t004_recursive_link_sets_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t004_recursive_link_sets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t005_recursive_link_list_t005_recursive_link_list_recursive_links",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t005_recursive_link_list_t005_recursive_link_list_recursive_links", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t005_recursive_link_list_t005_recursive_link_list_recursive_links_t005_recursive_link_lists_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t005_recursive_link_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t005_recursive_link_list_t005_recursive_link_list_recursive_links_t005_recursive_link_lists_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t005_recursive_link_lists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t007_leaf_t007_leaf_t007_leaves",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t007_leaf_t007_leaf_t007_leaves", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t007_leaf_t007_leaf_t007_leaves_t007_leaves_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t007_leaves",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t007_leaf_t007_leaf_t007_leaves_t007_leaves_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t007_leaves",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t007_root_t007_leaf_t007_leaves",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t007_root_t007_leaf_t007_leaves", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t007_root_t007_leaf_t007_leaves_t007_leaves_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t007_leaves",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t007_root_t007_leaf_t007_leaves_t007_roots_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t007_roots",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t013_composite_ref_parents",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    container_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t013_composite_ref_parents", x => x.id);
                    table.ForeignKey(
                        name: "FK_t013_composite_ref_parents_t013_composite_ref_parent_containers_container_id",
                        column: x => x.container_id,
                        principalSchema: "tst",
                        principalTable: "t013_composite_ref_parent_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t015_child_l1_records",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    child_l1_value = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    optional_child_id = table.Column<long>(type: "bigint", nullable: true),
                    required_child_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_child_l1_records", x => x.id);
                    table.ForeignKey(
                        name: "FK_t015_child_l1_records_t015_child_l2_records_optional_child_id",
                        column: x => x.optional_child_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_l2_records",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_t015_child_l1_records_t015_child_l2_records_required_child_id",
                        column: x => x.required_child_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_l2_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t015_parent_ordered_record_t015_child_owned_record_ordered_owned_children",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<long>(type: "bigint", nullable: false),
                    child_id = table.Column<long>(type: "bigint", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_parent_ordered_record_t015_child_owned_record_ordered_owned_children", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t015_parent_ordered_record_t015_child_owned_record_ordered_owned_children_t015_child_owned_records_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_owned_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t015_parent_ordered_record_t015_child_owned_record_ordered_owned_children_t015_parent_ordered_records_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t015_parent_ordered_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t016_composite_child_records",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    child_value = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    t016_composite_parent_record_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t016_composite_child_records", x => x.id);
                    table.ForeignKey(
                        name: "FK_t016_composite_child_records_t016_composite_parent_records_t016_composite_parent_record_id",
                        column: x => x.t016_composite_parent_record_id,
                        principalSchema: "tst",
                        principalTable: "t016_composite_parent_records",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "parent_child_children",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parent_child_children", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_parent_child_children_children_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_parent_child_children_parents_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "parents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t015_child_l1_record_t015_child_l2_record_children",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<long>(type: "bigint", nullable: false),
                    child_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_child_l1_record_t015_child_l2_record_children", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t015_child_l1_record_t015_child_l2_record_children_t015_child_l1_records_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_l1_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t015_child_l1_record_t015_child_l2_record_children_t015_child_l2_records_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_l2_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t015_parent_ordered_record_t015_child_l1_record_ordered_children",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<long>(type: "bigint", nullable: false),
                    child_id = table.Column<long>(type: "bigint", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_parent_ordered_record_t015_child_l1_record_ordered_children", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t015_parent_ordered_record_t015_child_l1_record_ordered_children_t015_child_l1_records_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_l1_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t015_parent_ordered_record_t015_child_l1_record_ordered_children_t015_parent_ordered_records_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t015_parent_ordered_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "composite_children",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    composites_container_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    nested_composites_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    index_in_nested_composites = table.Column<int>(type: "int", nullable: false),
                    t011_composite_ref_parent_container_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    index_in_t011_composite_ref_parent_container = table.Column<int>(type: "int", nullable: false),
                    t013_composite_ref_parent_container_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    index_in_t013_composite_ref_parent_container = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_composite_children", x => x.id);
                    table.ForeignKey(
                        name: "FK_composite_children_composites_containers_composites_container_id",
                        column: x => x.composites_container_id,
                        principalSchema: "tst",
                        principalTable: "composites_containers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_composite_children_t013_composite_ref_parent_containers_t013_composite_ref_parent_container_id",
                        column: x => x.t013_composite_ref_parent_container_id,
                        principalSchema: "tst",
                        principalTable: "t013_composite_ref_parent_containers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "composite_ref_parents",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    composite_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_composite_ref_parents", x => x.id);
                    table.ForeignKey(
                        name: "FK_composite_ref_parents_composite_children_composite_id",
                        column: x => x.composite_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "multiple_composite_refs",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    composite_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    optional_composite_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_multiple_composite_refs", x => x.id);
                    table.ForeignKey(
                        name: "FK_multiple_composite_refs_composite_children_composite_id",
                        column: x => x.composite_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_multiple_composite_refs_composite_children_optional_composite_id",
                        column: x => x.optional_composite_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "nested_composites",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    composite_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nested_composites", x => x.id);
                    table.ForeignKey(
                        name: "FK_nested_composites_composite_children_composite_id",
                        column: x => x.composite_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "optional_composite_ref_parents",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    composite_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_optional_composite_ref_parents", x => x.id);
                    table.ForeignKey(
                        name: "FK_optional_composite_ref_parents_composite_children_composite_id",
                        column: x => x.composite_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "t001_children",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    composite_child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t001_children", x => x.id);
                    table.ForeignKey(
                        name: "FK_t001_children_composite_children_composite_child_id",
                        column: x => x.composite_child_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t008_parents",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    raw_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t008_parents", x => x.id);
                    table.ForeignKey(
                        name: "FK_t008_parents_composite_children_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t008_parents_raws_raw_id",
                        column: x => x.raw_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t011_composite_ref_parent_containers",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    composite_child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t011_composite_ref_parent_containers", x => x.id);
                    table.ForeignKey(
                        name: "FK_t011_composite_ref_parent_containers_composite_children_composite_child_id",
                        column: x => x.composite_child_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t012_composite_ref_parent_containers",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    composite_child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t012_composite_ref_parent_containers", x => x.id);
                    table.ForeignKey(
                        name: "FK_t012_composite_ref_parent_containers_composite_children_composite_child_id",
                        column: x => x.composite_child_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nested_composite_roots",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    composite_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    optional_composite_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    nested_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    optional_raw_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nested_composite_roots", x => x.id);
                    table.ForeignKey(
                        name: "FK_nested_composite_roots_composite_children_composite_id",
                        column: x => x.composite_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_nested_composite_roots_composite_children_optional_composite_id",
                        column: x => x.optional_composite_id,
                        principalSchema: "tst",
                        principalTable: "composite_children",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_nested_composite_roots_nested_composites_nested_id",
                        column: x => x.nested_id,
                        principalSchema: "tst",
                        principalTable: "nested_composites",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_nested_composite_roots_raws_optional_raw_id",
                        column: x => x.optional_raw_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "t001_parent_owner_t001_child_t001_children",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t001_parent_owner_t001_child_t001_children", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t001_parent_owner_t001_child_t001_children_t001_children_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t001_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t001_parent_owner_t001_child_t001_children_t001_parent_owners_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t001_parent_owners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t011_composite_ref_parents",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    container_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t011_composite_ref_parents", x => x.id);
                    table.ForeignKey(
                        name: "FK_t011_composite_ref_parents_t011_composite_ref_parent_containers_container_id",
                        column: x => x.container_id,
                        principalSchema: "tst",
                        principalTable: "t011_composite_ref_parent_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t012_composite_ref_parents",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    container_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t012_composite_ref_parents", x => x.id);
                    table.ForeignKey(
                        name: "FK_t012_composite_ref_parents_t012_composite_ref_parent_containers_container_id",
                        column: x => x.container_id,
                        principalSchema: "tst",
                        principalTable: "t012_composite_ref_parent_containers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "nested_composite_root_raw_raw_lists",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nested_composite_root_raw_raw_lists", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_nested_composite_root_raw_raw_lists_nested_composite_roots_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "nested_composite_roots",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_nested_composite_root_raw_raw_lists_raws_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t009_composites",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false),
                    t009_principal_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    index_in_t009_principal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t009_composites", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "t009_principals",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    value = table.Column<int>(type: "int", nullable: false),
                    composite_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t009_principals", x => x.id);
                    table.ForeignKey(
                        name: "FK_t009_principals_t009_composites_composite_id",
                        column: x => x.composite_id,
                        principalSchema: "tst",
                        principalTable: "t009_composites",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t009_users",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    principal_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t009_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_t009_users_t009_principals_principal_id",
                        column: x => x.principal_id,
                        principalSchema: "tst",
                        principalTable: "t009_principals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t010_composite_ref_children",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raw_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    t010_composite_ref_parent_id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    index_in_t010_composite_ref_parent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t010_composite_ref_children", x => x.id);
                    table.ForeignKey(
                        name: "FK_t010_composite_ref_children_raws_raw_id",
                        column: x => x.raw_id,
                        principalSchema: "tst",
                        principalTable: "raws",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t010_composite_ref_parents",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    is_system = table.Column<bool>(type: "bit", nullable: false),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    t010_composite_ref_child_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t010_composite_ref_parents", x => x.id);
                    table.ForeignKey(
                        name: "FK_t010_composite_ref_parents_t010_composite_ref_children_t010_composite_ref_child_id",
                        column: x => x.t010_composite_ref_child_id,
                        principalSchema: "tst",
                        principalTable: "t010_composite_ref_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t015_composite_children",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    child_l1_value = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    t015_parent_record_id = table.Column<long>(type: "bigint", nullable: true),
                    t015_parent_ordered_record_id = table.Column<long>(type: "bigint", nullable: true),
                    index_in_t015_parent_ordered_record = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_composite_children", x => x.id);
                    table.ForeignKey(
                        name: "FK_t015_composite_children_t015_parent_ordered_records_t015_parent_ordered_record_id",
                        column: x => x.t015_parent_ordered_record_id,
                        principalSchema: "tst",
                        principalTable: "t015_parent_ordered_records",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "t015_parent_records",
                schema: "tst",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    revision = table.Column<long>(type: "bigint", nullable: false),
                    parent_value = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    optional_child_id = table.Column<long>(type: "bigint", nullable: true),
                    required_child_id = table.Column<long>(type: "bigint", nullable: false),
                    optional_composite_child_id = table.Column<long>(type: "bigint", nullable: true),
                    required_composite_child_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_parent_records", x => x.id);
                    table.ForeignKey(
                        name: "FK_t015_parent_records_t015_child_l1_records_optional_child_id",
                        column: x => x.optional_child_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_l1_records",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_t015_parent_records_t015_child_l1_records_required_child_id",
                        column: x => x.required_child_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_l1_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t015_parent_records_t015_composite_children_optional_composite_child_id",
                        column: x => x.optional_composite_child_id,
                        principalSchema: "tst",
                        principalTable: "t015_composite_children",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_t015_parent_records_t015_composite_children_required_composite_child_id",
                        column: x => x.required_composite_child_id,
                        principalSchema: "tst",
                        principalTable: "t015_composite_children",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "t015_parent_record_t015_child_l1_record_children",
                schema: "tst",
                columns: table => new
                {
                    parent_id = table.Column<long>(type: "bigint", nullable: false),
                    child_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t015_parent_record_t015_child_l1_record_children", x => new { x.parent_id, x.child_id });
                    table.ForeignKey(
                        name: "FK_t015_parent_record_t015_child_l1_record_children_t015_child_l1_records_child_id",
                        column: x => x.child_id,
                        principalSchema: "tst",
                        principalTable: "t015_child_l1_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_t015_parent_record_t015_child_l1_record_children_t015_parent_records_parent_id",
                        column: x => x.parent_id,
                        principalSchema: "tst",
                        principalTable: "t015_parent_records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_children_id",
                schema: "tst",
                table: "children",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_children_second_parent_id",
                schema: "tst",
                table: "children",
                column: "second_parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_composite_children_composites_container_id",
                schema: "tst",
                table: "composite_children",
                column: "composites_container_id");

            migrationBuilder.CreateIndex(
                name: "IX_composite_children_id",
                schema: "tst",
                table: "composite_children",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_composite_children_nested_composites_id",
                schema: "tst",
                table: "composite_children",
                column: "nested_composites_id");

            migrationBuilder.CreateIndex(
                name: "IX_composite_children_t011_composite_ref_parent_container_id",
                schema: "tst",
                table: "composite_children",
                column: "t011_composite_ref_parent_container_id");

            migrationBuilder.CreateIndex(
                name: "IX_composite_children_t013_composite_ref_parent_container_id",
                schema: "tst",
                table: "composite_children",
                column: "t013_composite_ref_parent_container_id");

            migrationBuilder.CreateIndex(
                name: "IX_composite_ref_parents_composite_id",
                schema: "tst",
                table: "composite_ref_parents",
                column: "composite_id");

            migrationBuilder.CreateIndex(
                name: "IX_composite_ref_parents_id",
                schema: "tst",
                table: "composite_ref_parents",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_composites_containers_id",
                schema: "tst",
                table: "composites_containers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mixed_container_raw_owneds_child_id",
                schema: "tst",
                table: "mixed_container_raw_owneds",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_mixed_container_raw_shareds_child_id",
                schema: "tst",
                table: "mixed_container_raw_shareds",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_mixed_containers_id",
                schema: "tst",
                table: "mixed_containers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_multiple_composite_refs_composite_id",
                schema: "tst",
                table: "multiple_composite_refs",
                column: "composite_id");

            migrationBuilder.CreateIndex(
                name: "IX_multiple_composite_refs_id",
                schema: "tst",
                table: "multiple_composite_refs",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_multiple_composite_refs_optional_composite_id",
                schema: "tst",
                table: "multiple_composite_refs",
                column: "optional_composite_id");

            migrationBuilder.CreateIndex(
                name: "IX_multiple_shared_container_raw_first_shareds_child_id",
                schema: "tst",
                table: "multiple_shared_container_raw_first_shareds",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_multiple_shared_container_raw_second_shareds_child_id",
                schema: "tst",
                table: "multiple_shared_container_raw_second_shareds",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_multiple_shared_containers_id",
                schema: "tst",
                table: "multiple_shared_containers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_multiple_shared_refs_id",
                schema: "tst",
                table: "multiple_shared_refs",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_multiple_shared_refs_optional_raw_id",
                schema: "tst",
                table: "multiple_shared_refs",
                column: "optional_raw_id");

            migrationBuilder.CreateIndex(
                name: "IX_multiple_shared_refs_raw_id",
                schema: "tst",
                table: "multiple_shared_refs",
                column: "raw_id");

            migrationBuilder.CreateIndex(
                name: "IX_nested_composite_root_raw_raw_lists_child_id",
                schema: "tst",
                table: "nested_composite_root_raw_raw_lists",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_nested_composite_roots_composite_id",
                schema: "tst",
                table: "nested_composite_roots",
                column: "composite_id");

            migrationBuilder.CreateIndex(
                name: "IX_nested_composite_roots_id",
                schema: "tst",
                table: "nested_composite_roots",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_nested_composite_roots_nested_id",
                schema: "tst",
                table: "nested_composite_roots",
                column: "nested_id");

            migrationBuilder.CreateIndex(
                name: "IX_nested_composite_roots_optional_composite_id",
                schema: "tst",
                table: "nested_composite_roots",
                column: "optional_composite_id");

            migrationBuilder.CreateIndex(
                name: "IX_nested_composite_roots_optional_raw_id",
                schema: "tst",
                table: "nested_composite_roots",
                column: "optional_raw_id");

            migrationBuilder.CreateIndex(
                name: "IX_nested_composites_composite_id",
                schema: "tst",
                table: "nested_composites",
                column: "composite_id");

            migrationBuilder.CreateIndex(
                name: "IX_nested_composites_id",
                schema: "tst",
                table: "nested_composites",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_optional_composite_ref_parents_composite_id",
                schema: "tst",
                table: "optional_composite_ref_parents",
                column: "composite_id");

            migrationBuilder.CreateIndex(
                name: "IX_optional_composite_ref_parents_id",
                schema: "tst",
                table: "optional_composite_ref_parents",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_optional_shared_refs_id",
                schema: "tst",
                table: "optional_shared_refs",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_optional_shared_refs_raw_id",
                schema: "tst",
                table: "optional_shared_refs",
                column: "raw_id");

            migrationBuilder.CreateIndex(
                name: "IX_owner_container_raw_raws_child_id",
                schema: "tst",
                table: "owner_container_raw_raws",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_owner_containers_id",
                schema: "tst",
                table: "owner_containers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parent_child_children_child_id",
                schema: "tst",
                table: "parent_child_children",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_parent_with_shared_list_raw_raw_lists_child_id",
                schema: "tst",
                table: "parent_with_shared_list_raw_raw_lists",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_parent_with_shared_lists_id",
                schema: "tst",
                table: "parent_with_shared_lists",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parents_id",
                schema: "tst",
                table: "parents",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_raws_id",
                schema: "tst",
                table: "raws",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_required_shared_refs_id",
                schema: "tst",
                table: "required_shared_refs",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_required_shared_refs_raw_id",
                schema: "tst",
                table: "required_shared_refs",
                column: "raw_id");

            migrationBuilder.CreateIndex(
                name: "IX_shared_container_raw_shareds_child_id",
                schema: "tst",
                table: "shared_container_raw_shareds",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_shared_containers_id",
                schema: "tst",
                table: "shared_containers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t001_children_composite_child_id",
                schema: "tst",
                table: "t001_children",
                column: "composite_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t001_children_id",
                schema: "tst",
                table: "t001_children",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t001_parent_owner_t001_child_t001_children_child_id",
                schema: "tst",
                table: "t001_parent_owner_t001_child_t001_children",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t001_parent_owners_id",
                schema: "tst",
                table: "t001_parent_owners",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t002_child_holders_id",
                schema: "tst",
                table: "t002_child_holders",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t002_child_holders_t002_child_id",
                schema: "tst",
                table: "t002_child_holders",
                column: "t002_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t002_children_id",
                schema: "tst",
                table: "t002_children",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t002_parent_owner_t002_child_t002_children_child_id",
                schema: "tst",
                table: "t002_parent_owner_t002_child_t002_children",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t002_parent_owners_id",
                schema: "tst",
                table: "t002_parent_owners",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t003_child_holders_id",
                schema: "tst",
                table: "t003_child_holders",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t003_child_holders_t003_child_id",
                schema: "tst",
                table: "t003_child_holders",
                column: "t003_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t003_children_id",
                schema: "tst",
                table: "t003_children",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t003_parent_owner_t003_child_t003_children_child_id",
                schema: "tst",
                table: "t003_parent_owner_t003_child_t003_children",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t003_parent_owners_id",
                schema: "tst",
                table: "t003_parent_owners",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t004_recursive_link_set_t004_recursive_link_set_recursive_links_child_id",
                schema: "tst",
                table: "t004_recursive_link_set_t004_recursive_link_set_recursive_links",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t004_recursive_link_sets_id",
                schema: "tst",
                table: "t004_recursive_link_sets",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t005_recursive_link_list_t005_recursive_link_list_recursive_links_child_id",
                schema: "tst",
                table: "t005_recursive_link_list_t005_recursive_link_list_recursive_links",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t005_recursive_link_lists_id",
                schema: "tst",
                table: "t005_recursive_link_lists",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t006_perf_max_query_items_id",
                schema: "tst",
                table: "t006_perf_max_query_items",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t006_perf_max_query_values_id",
                schema: "tst",
                table: "t006_perf_max_query_values",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t007_leaf_t007_leaf_t007_leaves_child_id",
                schema: "tst",
                table: "t007_leaf_t007_leaf_t007_leaves",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t007_leaves_id",
                schema: "tst",
                table: "t007_leaves",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t007_root_t007_leaf_t007_leaves_child_id",
                schema: "tst",
                table: "t007_root_t007_leaf_t007_leaves",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t007_roots_id",
                schema: "tst",
                table: "t007_roots",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t008_parents_child_id",
                schema: "tst",
                table: "t008_parents",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t008_parents_id",
                schema: "tst",
                table: "t008_parents",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t008_parents_raw_id",
                schema: "tst",
                table: "t008_parents",
                column: "raw_id");

            migrationBuilder.CreateIndex(
                name: "IX_t009_composites_id",
                schema: "tst",
                table: "t009_composites",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t009_composites_t009_principal_id",
                schema: "tst",
                table: "t009_composites",
                column: "t009_principal_id");

            migrationBuilder.CreateIndex(
                name: "IX_t009_principals_composite_id",
                schema: "tst",
                table: "t009_principals",
                column: "composite_id");

            migrationBuilder.CreateIndex(
                name: "IX_t009_principals_id",
                schema: "tst",
                table: "t009_principals",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t009_users_id",
                schema: "tst",
                table: "t009_users",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t009_users_principal_id",
                schema: "tst",
                table: "t009_users",
                column: "principal_id");

            migrationBuilder.CreateIndex(
                name: "IX_t010_composite_ref_children_id",
                schema: "tst",
                table: "t010_composite_ref_children",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t010_composite_ref_children_raw_id",
                schema: "tst",
                table: "t010_composite_ref_children",
                column: "raw_id");

            migrationBuilder.CreateIndex(
                name: "IX_t010_composite_ref_children_t010_composite_ref_parent_id",
                schema: "tst",
                table: "t010_composite_ref_children",
                column: "t010_composite_ref_parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_t010_composite_ref_parents_id",
                schema: "tst",
                table: "t010_composite_ref_parents",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t010_composite_ref_parents_t010_composite_ref_child_id",
                schema: "tst",
                table: "t010_composite_ref_parents",
                column: "t010_composite_ref_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t011_composite_ref_parent_containers_composite_child_id",
                schema: "tst",
                table: "t011_composite_ref_parent_containers",
                column: "composite_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t011_composite_ref_parent_containers_id",
                schema: "tst",
                table: "t011_composite_ref_parent_containers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t011_composite_ref_parents_container_id",
                schema: "tst",
                table: "t011_composite_ref_parents",
                column: "container_id");

            migrationBuilder.CreateIndex(
                name: "IX_t011_composite_ref_parents_id",
                schema: "tst",
                table: "t011_composite_ref_parents",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t012_composite_ref_parent_containers_composite_child_id",
                schema: "tst",
                table: "t012_composite_ref_parent_containers",
                column: "composite_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t012_composite_ref_parent_containers_id",
                schema: "tst",
                table: "t012_composite_ref_parent_containers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t012_composite_ref_parents_container_id",
                schema: "tst",
                table: "t012_composite_ref_parents",
                column: "container_id");

            migrationBuilder.CreateIndex(
                name: "IX_t012_composite_ref_parents_id",
                schema: "tst",
                table: "t012_composite_ref_parents",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t013_composite_ref_parent_containers_id",
                schema: "tst",
                table: "t013_composite_ref_parent_containers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t013_composite_ref_parents_container_id",
                schema: "tst",
                table: "t013_composite_ref_parents",
                column: "container_id");

            migrationBuilder.CreateIndex(
                name: "IX_t013_composite_ref_parents_id",
                schema: "tst",
                table: "t013_composite_ref_parents",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t014_auto_create_values_id",
                schema: "tst",
                table: "t014_auto_create_values",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t014_auto_create_values_reference_id",
                schema: "tst",
                table: "t014_auto_create_values",
                column: "reference_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_child_l1_record_t015_child_l2_record_children_child_id",
                schema: "tst",
                table: "t015_child_l1_record_t015_child_l2_record_children",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_child_l1_records_id",
                schema: "tst",
                table: "t015_child_l1_records",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t015_child_l1_records_optional_child_id",
                schema: "tst",
                table: "t015_child_l1_records",
                column: "optional_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_child_l1_records_required_child_id",
                schema: "tst",
                table: "t015_child_l1_records",
                column: "required_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_child_l2_records_id",
                schema: "tst",
                table: "t015_child_l2_records",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t015_child_owned_records_id",
                schema: "tst",
                table: "t015_child_owned_records",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t015_composite_children_id",
                schema: "tst",
                table: "t015_composite_children",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t015_composite_children_t015_parent_ordered_record_id",
                schema: "tst",
                table: "t015_composite_children",
                column: "t015_parent_ordered_record_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_composite_children_t015_parent_record_id",
                schema: "tst",
                table: "t015_composite_children",
                column: "t015_parent_record_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_ordered_record_t015_child_l1_record_ordered_children_child_id",
                schema: "tst",
                table: "t015_parent_ordered_record_t015_child_l1_record_ordered_children",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_ordered_record_t015_child_owned_record_ordered_owned_children_child_id",
                schema: "tst",
                table: "t015_parent_ordered_record_t015_child_owned_record_ordered_owned_children",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_ordered_records_id",
                schema: "tst",
                table: "t015_parent_ordered_records",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_record_t015_child_l1_record_children_child_id",
                schema: "tst",
                table: "t015_parent_record_t015_child_l1_record_children",
                column: "child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_records_id",
                schema: "tst",
                table: "t015_parent_records",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_records_optional_child_id",
                schema: "tst",
                table: "t015_parent_records",
                column: "optional_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_records_optional_composite_child_id",
                schema: "tst",
                table: "t015_parent_records",
                column: "optional_composite_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_records_required_child_id",
                schema: "tst",
                table: "t015_parent_records",
                column: "required_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t015_parent_records_required_composite_child_id",
                schema: "tst",
                table: "t015_parent_records",
                column: "required_composite_child_id");

            migrationBuilder.CreateIndex(
                name: "IX_t016_composite_child_records_id",
                schema: "tst",
                table: "t016_composite_child_records",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_t016_composite_child_records_t016_composite_parent_record_id",
                schema: "tst",
                table: "t016_composite_child_records",
                column: "t016_composite_parent_record_id");

            migrationBuilder.CreateIndex(
                name: "IX_t016_composite_parent_records_id",
                schema: "tst",
                table: "t016_composite_parent_records",
                column: "id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_composite_children_nested_composites_nested_composites_id",
                schema: "tst",
                table: "composite_children",
                column: "nested_composites_id",
                principalSchema: "tst",
                principalTable: "nested_composites",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_composite_children_t011_composite_ref_parent_containers_t011_composite_ref_parent_container_id",
                schema: "tst",
                table: "composite_children",
                column: "t011_composite_ref_parent_container_id",
                principalSchema: "tst",
                principalTable: "t011_composite_ref_parent_containers",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_t009_composites_t009_principals_t009_principal_id",
                schema: "tst",
                table: "t009_composites",
                column: "t009_principal_id",
                principalSchema: "tst",
                principalTable: "t009_principals",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_t010_composite_ref_children_t010_composite_ref_parents_t010_composite_ref_parent_id",
                schema: "tst",
                table: "t010_composite_ref_children",
                column: "t010_composite_ref_parent_id",
                principalSchema: "tst",
                principalTable: "t010_composite_ref_parents",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_t015_composite_children_t015_parent_records_t015_parent_record_id",
                schema: "tst",
                table: "t015_composite_children",
                column: "t015_parent_record_id",
                principalSchema: "tst",
                principalTable: "t015_parent_records",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_composite_children_composites_containers_composites_container_id",
                schema: "tst",
                table: "composite_children");

            migrationBuilder.DropForeignKey(
                name: "FK_composite_children_nested_composites_nested_composites_id",
                schema: "tst",
                table: "composite_children");

            migrationBuilder.DropForeignKey(
                name: "FK_composite_children_t011_composite_ref_parent_containers_t011_composite_ref_parent_container_id",
                schema: "tst",
                table: "composite_children");

            migrationBuilder.DropForeignKey(
                name: "FK_t010_composite_ref_children_raws_raw_id",
                schema: "tst",
                table: "t010_composite_ref_children");

            migrationBuilder.DropForeignKey(
                name: "FK_t009_composites_t009_principals_t009_principal_id",
                schema: "tst",
                table: "t009_composites");

            migrationBuilder.DropForeignKey(
                name: "FK_t010_composite_ref_children_t010_composite_ref_parents_t010_composite_ref_parent_id",
                schema: "tst",
                table: "t010_composite_ref_children");

            migrationBuilder.DropForeignKey(
                name: "FK_t015_parent_records_t015_child_l1_records_optional_child_id",
                schema: "tst",
                table: "t015_parent_records");

            migrationBuilder.DropForeignKey(
                name: "FK_t015_parent_records_t015_child_l1_records_required_child_id",
                schema: "tst",
                table: "t015_parent_records");

            migrationBuilder.DropForeignKey(
                name: "FK_t015_composite_children_t015_parent_ordered_records_t015_parent_ordered_record_id",
                schema: "tst",
                table: "t015_composite_children");

            migrationBuilder.DropForeignKey(
                name: "FK_t015_composite_children_t015_parent_records_t015_parent_record_id",
                schema: "tst",
                table: "t015_composite_children");

            migrationBuilder.DropTable(
                name: "composite_ref_parents",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "mixed_container_raw_owneds",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "mixed_container_raw_shareds",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "multiple_composite_refs",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "multiple_shared_container_raw_first_shareds",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "multiple_shared_container_raw_second_shareds",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "multiple_shared_refs",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "nested_composite_root_raw_raw_lists",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "optional_composite_ref_parents",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "optional_shared_refs",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "owner_container_raw_raws",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "parent_child_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "parent_with_shared_list_raw_raw_lists",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "required_shared_refs",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "shared_container_raw_shareds",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t001_parent_owner_t001_child_t001_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t002_child_holders",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t002_parent_owner_t002_child_t002_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t003_child_holders",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t003_parent_owner_t003_child_t003_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t004_recursive_link_set_t004_recursive_link_set_recursive_links",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t005_recursive_link_list_t005_recursive_link_list_recursive_links",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t006_perf_max_query_items",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t006_perf_max_query_values",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t007_leaf_t007_leaf_t007_leaves",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t007_root_t007_leaf_t007_leaves",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t008_parents",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t009_users",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t011_composite_ref_parents",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t012_composite_ref_parents",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t013_composite_ref_parents",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t014_auto_create_values",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_child_l1_record_t015_child_l2_record_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_parent_ordered_record_t015_child_l1_record_ordered_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_parent_ordered_record_t015_child_owned_record_ordered_owned_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_parent_record_t015_child_l1_record_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t016_composite_child_records",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "mixed_containers",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "multiple_shared_containers",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "nested_composite_roots",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "owner_containers",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "parent_with_shared_lists",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "shared_containers",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t001_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t001_parent_owners",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t002_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t002_parent_owners",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t003_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t003_parent_owners",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t004_recursive_link_sets",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t005_recursive_link_lists",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t007_leaves",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t007_roots",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t012_composite_ref_parent_containers",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_child_owned_records",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t016_composite_parent_records",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "parents",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "composites_containers",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "nested_composites",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t011_composite_ref_parent_containers",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "composite_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t013_composite_ref_parent_containers",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "raws",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t009_principals",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t009_composites",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t010_composite_ref_parents",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t010_composite_ref_children",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_child_l1_records",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_child_l2_records",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_parent_ordered_records",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_parent_records",
                schema: "tst");

            migrationBuilder.DropTable(
                name: "t015_composite_children",
                schema: "tst");
        }
    }
}
