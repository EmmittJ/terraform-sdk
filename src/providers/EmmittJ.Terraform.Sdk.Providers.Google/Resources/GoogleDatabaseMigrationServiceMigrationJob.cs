using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dump_flags in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock() : TerraformBlock("dump_flags")
{
}

/// <summary>
/// Block type for performance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock() : TerraformBlock("performance_config")
{
    /// <summary>
    /// Initial dump parallelism level. Possible values: [&amp;quot;MIN&amp;quot;, &amp;quot;OPTIMAL&amp;quot;, &amp;quot;MAX&amp;quot;]
    /// </summary>
    [TerraformProperty("dump_parallel_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DumpParallelLevel { get; set; }

}

/// <summary>
/// Block type for reverse_ssh_connectivity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock() : TerraformBlock("reverse_ssh_connectivity")
{
    /// <summary>
    /// The name of the virtual machine (Compute Engine) used as the bastion server
    /// for the SSH tunnel.
    /// </summary>
    [TerraformProperty("vm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Vm { get; set; }

    /// <summary>
    /// The IP of the virtual machine (Compute Engine) used as the bastion server
    /// for the SSH tunnel.
    /// </summary>
    [TerraformProperty("vm_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VmIp { get; set; }

    /// <summary>
    /// The forwarding port of the virtual machine (Compute Engine) used as the
    /// bastion server for the SSH tunnel.
    /// </summary>
    [TerraformProperty("vm_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VmPort { get; set; }

    /// <summary>
    /// The name of the VPC to peer with the Cloud SQL private network.
    /// </summary>
    [TerraformProperty("vpc")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Vpc { get; set; }

}

/// <summary>
/// Block type for static_ip_connectivity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock() : TerraformBlock("static_ip_connectivity")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_peering_connectivity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock() : TerraformBlock("vpc_peering_connectivity")
{
    /// <summary>
    /// The name of the VPC network to peer with the Cloud SQL private network.
    /// </summary>
    [TerraformProperty("vpc")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Vpc { get; set; }

}

/// <summary>
/// Manages a google_database_migration_service_migration_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDatabaseMigrationServiceMigrationJob : TerraformResource
{
    public GoogleDatabaseMigrationServiceMigrationJob(string name) : base("google_database_migration_service_migration_job", name)
    {
    }

    /// <summary>
    /// The name of the destination connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{destinationConnectionProfile}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformProperty("destination")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The migration job display name.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The path to the dump file in Google Cloud Storage,
    /// in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
    /// This field and the &amp;quot;dump_flags&amp;quot; field are mutually exclusive.
    /// </summary>
    [TerraformProperty("dump_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DumpPath { get; set; }

    /// <summary>
    /// The type of the data dump. Supported for MySQL to CloudSQL for MySQL
    /// migrations only. Possible values: [&amp;quot;LOGICAL&amp;quot;, &amp;quot;PHYSICAL&amp;quot;]
    /// </summary>
    [TerraformProperty("dump_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DumpType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource labels for migration job to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the migration job should reside.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The ID of the migration job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationJobId is required")]
    [TerraformProperty("migration_job_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MigrationJobId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the source connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{sourceConnectionProfile}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The type of the migration job. Possible values: [&amp;quot;ONE_TIME&amp;quot;, &amp;quot;CONTINUOUS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for dump_flags.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DumpFlags block(s) allowed")]
    [TerraformProperty("dump_flags")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock> DumpFlags { get; set; } = new();

    /// <summary>
    /// Block for performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerformanceConfig block(s) allowed")]
    [TerraformProperty("performance_config")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock> PerformanceConfig { get; set; } = new();

    /// <summary>
    /// Block for reverse_ssh_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseSshConnectivity block(s) allowed")]
    [TerraformProperty("reverse_ssh_connectivity")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock> ReverseSshConnectivity { get; set; } = new();

    /// <summary>
    /// Block for static_ip_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticIpConnectivity block(s) allowed")]
    [TerraformProperty("static_ip_connectivity")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock> StaticIpConnectivity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc_peering_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcPeeringConnectivity block(s) allowed")]
    [TerraformProperty("vpc_peering_connectivity")]
    public TerraformList<GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock> VpcPeeringConnectivity { get; set; } = new();

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    [TerraformProperty("error")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Error { get; }

    /// <summary>
    /// The name of this migration job resource in the form of projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The current migration job phase.
    /// </summary>
    [TerraformProperty("phase")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Phase { get; }

    /// <summary>
    /// The current migration job state.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
