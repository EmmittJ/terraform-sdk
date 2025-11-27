using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dump_flags in GoogleDatabaseMigrationServiceMigrationJob.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dump_flags";

    /// <summary>
    /// DumpFlags block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlockDumpFlagsBlock>? DumpFlags
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlockDumpFlagsBlock>>("dump_flags");
        set => SetArgument("dump_flags", value);
    }

}

/// <summary>
/// Block type for dump_flags in GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlockDumpFlagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dump_flags";

    /// <summary>
    /// The name of the flag
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The vale of the flag
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for performance_config in GoogleDatabaseMigrationServiceMigrationJob.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "performance_config";

    /// <summary>
    /// Initial dump parallelism level. Possible values: [&amp;quot;MIN&amp;quot;, &amp;quot;OPTIMAL&amp;quot;, &amp;quot;MAX&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DumpParallelLevel
    {
        get => new TerraformReference<string>(this, "dump_parallel_level");
        set => SetArgument("dump_parallel_level", value);
    }

}


/// <summary>
/// Block type for reverse_ssh_connectivity in GoogleDatabaseMigrationServiceMigrationJob.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reverse_ssh_connectivity";

    /// <summary>
    /// The name of the virtual machine (Compute Engine) used as the bastion server
    /// for the SSH tunnel.
    /// </summary>
    public TerraformValue<string>? Vm
    {
        get => new TerraformReference<string>(this, "vm");
        set => SetArgument("vm", value);
    }

    /// <summary>
    /// The IP of the virtual machine (Compute Engine) used as the bastion server
    /// for the SSH tunnel.
    /// </summary>
    public TerraformValue<string>? VmIp
    {
        get => new TerraformReference<string>(this, "vm_ip");
        set => SetArgument("vm_ip", value);
    }

    /// <summary>
    /// The forwarding port of the virtual machine (Compute Engine) used as the
    /// bastion server for the SSH tunnel.
    /// </summary>
    public TerraformValue<double>? VmPort
    {
        get => new TerraformReference<double>(this, "vm_port");
        set => SetArgument("vm_port", value);
    }

    /// <summary>
    /// The name of the VPC to peer with the Cloud SQL private network.
    /// </summary>
    public TerraformValue<string>? Vpc
    {
        get => new TerraformReference<string>(this, "vpc");
        set => SetArgument("vpc", value);
    }

}


/// <summary>
/// Block type for static_ip_connectivity in GoogleDatabaseMigrationServiceMigrationJob.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_ip_connectivity";

}


/// <summary>
/// Block type for timeouts in GoogleDatabaseMigrationServiceMigrationJob.
/// Nesting mode: single
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc_peering_connectivity in GoogleDatabaseMigrationServiceMigrationJob.
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_peering_connectivity";

    /// <summary>
    /// The name of the VPC network to peer with the Cloud SQL private network.
    /// </summary>
    public TerraformValue<string>? Vpc
    {
        get => new TerraformReference<string>(this, "vpc");
        set => SetArgument("vpc", value);
    }

}


/// <summary>
/// Represents a google_database_migration_service_migration_job Terraform resource.
/// Manages a google_database_migration_service_migration_job resource.
/// </summary>
public partial class GoogleDatabaseMigrationServiceMigrationJob(string name) : TerraformResource("google_database_migration_service_migration_job", name)
{
    /// <summary>
    /// The name of the destination connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{destinationConnectionProfile}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The migration job display name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The path to the dump file in Google Cloud Storage,
    /// in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
    /// This field and the &amp;quot;dump_flags&amp;quot; field are mutually exclusive.
    /// </summary>
    public TerraformValue<string>? DumpPath
    {
        get => new TerraformReference<string>(this, "dump_path");
        set => SetArgument("dump_path", value);
    }

    /// <summary>
    /// The type of the data dump. Supported for MySQL to CloudSQL for MySQL
    /// migrations only. Possible values: [&amp;quot;LOGICAL&amp;quot;, &amp;quot;PHYSICAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DumpType
    {
        get => new TerraformReference<string>(this, "dump_type");
        set => SetArgument("dump_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource labels for migration job to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location where the migration job should reside.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the migration job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationJobId is required")]
    public required TerraformValue<string> MigrationJobId
    {
        get => new TerraformReference<string>(this, "migration_job_id");
        set => SetArgument("migration_job_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the source connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{sourceConnectionProfile}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The type of the migration job. Possible values: [&amp;quot;ONE_TIME&amp;quot;, &amp;quot;CONTINUOUS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    public TerraformList<TerraformMap<object>> Error
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "error").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of this migration job resource in the form of projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The current migration job phase.
    /// </summary>
    public TerraformValue<string> Phase
    {
        get => new TerraformReference<string>(this, "phase");
    }

    /// <summary>
    /// The current migration job state.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// DumpFlags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DumpFlags block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock>? DumpFlags
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock>>("dump_flags");
        set => SetArgument("dump_flags", value);
    }

    /// <summary>
    /// PerformanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerformanceConfig block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock>? PerformanceConfig
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock>>("performance_config");
        set => SetArgument("performance_config", value);
    }

    /// <summary>
    /// ReverseSshConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseSshConnectivity block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock>? ReverseSshConnectivity
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock>>("reverse_ssh_connectivity");
        set => SetArgument("reverse_ssh_connectivity", value);
    }

    /// <summary>
    /// StaticIpConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticIpConnectivity block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock>? StaticIpConnectivity
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock>>("static_ip_connectivity");
        set => SetArgument("static_ip_connectivity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcPeeringConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcPeeringConnectivity block(s) allowed")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock>? VpcPeeringConnectivity
    {
        get => GetArgument<TerraformList<GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock>>("vpc_peering_connectivity");
        set => SetArgument("vpc_peering_connectivity", value);
    }

}
