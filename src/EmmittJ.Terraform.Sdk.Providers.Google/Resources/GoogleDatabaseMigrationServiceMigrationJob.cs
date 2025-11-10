using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dump_flags in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Initial dump parallelism level. Possible values: [&amp;quot;MIN&amp;quot;, &amp;quot;OPTIMAL&amp;quot;, &amp;quot;MAX&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DumpParallelLevel
    {
        get => GetProperty<TerraformProperty<string>>("dump_parallel_level");
        set => WithProperty("dump_parallel_level", value);
    }

}

/// <summary>
/// Block type for reverse_ssh_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// The name of the virtual machine (Compute Engine) used as the bastion server
    /// for the SSH tunnel.
    /// </summary>
    public TerraformProperty<string>? Vm
    {
        get => GetProperty<TerraformProperty<string>>("vm");
        set => WithProperty("vm", value);
    }

    /// <summary>
    /// The IP of the virtual machine (Compute Engine) used as the bastion server
    /// for the SSH tunnel.
    /// </summary>
    public TerraformProperty<string>? VmIp
    {
        get => GetProperty<TerraformProperty<string>>("vm_ip");
        set => WithProperty("vm_ip", value);
    }

    /// <summary>
    /// The forwarding port of the virtual machine (Compute Engine) used as the
    /// bastion server for the SSH tunnel.
    /// </summary>
    public TerraformProperty<double>? VmPort
    {
        get => GetProperty<TerraformProperty<double>>("vm_port");
        set => WithProperty("vm_port", value);
    }

    /// <summary>
    /// The name of the VPC to peer with the Cloud SQL private network.
    /// </summary>
    public TerraformProperty<string>? Vpc
    {
        get => GetProperty<TerraformProperty<string>>("vpc");
        set => WithProperty("vpc", value);
    }

}

/// <summary>
/// Block type for static_ip_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_peering_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// The name of the VPC network to peer with the Cloud SQL private network.
    /// </summary>
    public TerraformProperty<string>? Vpc
    {
        get => GetProperty<TerraformProperty<string>>("vpc");
        set => WithProperty("vpc", value);
    }

}

/// <summary>
/// Manages a google_database_migration_service_migration_job resource.
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJob : TerraformResource
{
    public GoogleDatabaseMigrationServiceMigrationJob(string name) : base("google_database_migration_service_migration_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("error");
        this.DeclareOutput("name");
        this.DeclareOutput("phase");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The name of the destination connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{destinationConnectionProfile}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetProperty<TerraformProperty<string>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// The migration job display name.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The path to the dump file in Google Cloud Storage,
    /// in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
    /// This field and the &amp;quot;dump_flags&amp;quot; field are mutually exclusive.
    /// </summary>
    public TerraformProperty<string>? DumpPath
    {
        get => GetProperty<TerraformProperty<string>>("dump_path");
        set => this.WithProperty("dump_path", value);
    }

    /// <summary>
    /// The type of the data dump. Supported for MySQL to CloudSQL for MySQL
    /// migrations only. Possible values: [&amp;quot;LOGICAL&amp;quot;, &amp;quot;PHYSICAL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DumpType
    {
        get => GetProperty<TerraformProperty<string>>("dump_type");
        set => this.WithProperty("dump_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource labels for migration job to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location where the migration job should reside.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID of the migration job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationJobId is required")]
    public required TerraformProperty<string> MigrationJobId
    {
        get => GetProperty<TerraformProperty<string>>("migration_job_id");
        set => this.WithProperty("migration_job_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the source connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{sourceConnectionProfile}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The type of the migration job. Possible values: [&amp;quot;ONE_TIME&amp;quot;, &amp;quot;CONTINUOUS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for dump_flags.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DumpFlags block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock>? DumpFlags
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock>>("dump_flags");
        set => this.WithProperty("dump_flags", value);
    }

    /// <summary>
    /// Block for performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerformanceConfig block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock>? PerformanceConfig
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock>>("performance_config");
        set => this.WithProperty("performance_config", value);
    }

    /// <summary>
    /// Block for reverse_ssh_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseSshConnectivity block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock>? ReverseSshConnectivity
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock>>("reverse_ssh_connectivity");
        set => this.WithProperty("reverse_ssh_connectivity", value);
    }

    /// <summary>
    /// Block for static_ip_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticIpConnectivity block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock>? StaticIpConnectivity
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock>>("static_ip_connectivity");
        set => this.WithProperty("static_ip_connectivity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_peering_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcPeeringConnectivity block(s) allowed")]
    public List<GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock>? VpcPeeringConnectivity
    {
        get => GetProperty<List<GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock>>("vpc_peering_connectivity");
        set => this.WithProperty("vpc_peering_connectivity", value);
    }

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    public TerraformExpression Error => this["error"];

    /// <summary>
    /// The name of this migration job resource in the form of projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current migration job phase.
    /// </summary>
    public TerraformExpression Phase => this["phase"];

    /// <summary>
    /// The current migration job state.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
