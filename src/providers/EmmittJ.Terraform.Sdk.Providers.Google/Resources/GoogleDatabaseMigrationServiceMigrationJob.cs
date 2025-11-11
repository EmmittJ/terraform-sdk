using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for dump_flags in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock
{
}

/// <summary>
/// Block type for performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock
{
    /// <summary>
    /// Initial dump parallelism level. Possible values: [&amp;quot;MIN&amp;quot;, &amp;quot;OPTIMAL&amp;quot;, &amp;quot;MAX&amp;quot;]
    /// </summary>
    [TerraformPropertyName("dump_parallel_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DumpParallelLevel { get; set; }

}

/// <summary>
/// Block type for reverse_ssh_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock
{
    /// <summary>
    /// The name of the virtual machine (Compute Engine) used as the bastion server
    /// for the SSH tunnel.
    /// </summary>
    [TerraformPropertyName("vm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Vm { get; set; }

    /// <summary>
    /// The IP of the virtual machine (Compute Engine) used as the bastion server
    /// for the SSH tunnel.
    /// </summary>
    [TerraformPropertyName("vm_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VmIp { get; set; }

    /// <summary>
    /// The forwarding port of the virtual machine (Compute Engine) used as the
    /// bastion server for the SSH tunnel.
    /// </summary>
    [TerraformPropertyName("vm_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VmPort { get; set; }

    /// <summary>
    /// The name of the VPC to peer with the Cloud SQL private network.
    /// </summary>
    [TerraformPropertyName("vpc")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Vpc { get; set; }

}

/// <summary>
/// Block type for static_ip_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_peering_connectivity in .
/// Nesting mode: list
/// </summary>
public class GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock
{
    /// <summary>
    /// The name of the VPC network to peer with the Cloud SQL private network.
    /// </summary>
    [TerraformPropertyName("vpc")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Vpc { get; set; }

}

/// <summary>
/// Manages a google_database_migration_service_migration_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDatabaseMigrationServiceMigrationJob : TerraformResource
{
    public GoogleDatabaseMigrationServiceMigrationJob(string name) : base("google_database_migration_service_migration_job", name)
    {
    }

    /// <summary>
    /// The name of the destination connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{destinationConnectionProfile}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [TerraformPropertyName("destination")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The migration job display name.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The path to the dump file in Google Cloud Storage,
    /// in the format: (gs://[BUCKET_NAME]/[OBJECT_NAME]).
    /// This field and the &amp;quot;dump_flags&amp;quot; field are mutually exclusive.
    /// </summary>
    [TerraformPropertyName("dump_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DumpPath { get; set; }

    /// <summary>
    /// The type of the data dump. Supported for MySQL to CloudSQL for MySQL
    /// migrations only. Possible values: [&amp;quot;LOGICAL&amp;quot;, &amp;quot;PHYSICAL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("dump_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DumpType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The resource labels for migration job to use to annotate any related underlying resources such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the migration job should reside.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The ID of the migration job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MigrationJobId is required")]
    [TerraformPropertyName("migration_job_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MigrationJobId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The name of the source connection profile resource in the form of projects/{project}/locations/{location}/connectionProfiles/{sourceConnectionProfile}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The type of the migration job. Possible values: [&amp;quot;ONE_TIME&amp;quot;, &amp;quot;CONTINUOUS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for dump_flags.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DumpFlags block(s) allowed")]
    [TerraformPropertyName("dump_flags")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceMigrationJobDumpFlagsBlock>>? DumpFlags { get; set; }

    /// <summary>
    /// Block for performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerformanceConfig block(s) allowed")]
    [TerraformPropertyName("performance_config")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceMigrationJobPerformanceConfigBlock>>? PerformanceConfig { get; set; }

    /// <summary>
    /// Block for reverse_ssh_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReverseSshConnectivity block(s) allowed")]
    [TerraformPropertyName("reverse_ssh_connectivity")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceMigrationJobReverseSshConnectivityBlock>>? ReverseSshConnectivity { get; set; }

    /// <summary>
    /// Block for static_ip_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticIpConnectivity block(s) allowed")]
    [TerraformPropertyName("static_ip_connectivity")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceMigrationJobStaticIpConnectivityBlock>>? StaticIpConnectivity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDatabaseMigrationServiceMigrationJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_peering_connectivity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcPeeringConnectivity block(s) allowed")]
    [TerraformPropertyName("vpc_peering_connectivity")]
    public TerraformList<TerraformBlock<GoogleDatabaseMigrationServiceMigrationJobVpcPeeringConnectivityBlock>>? VpcPeeringConnectivity { get; set; }

    /// <summary>
    /// Output only. The timestamp when the resource was created. A timestamp in RFC3339 UTC &#39;Zulu&#39; format, accurate to nanoseconds. Example: &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Output only. The error details in case of state FAILED.
    /// </summary>
    [TerraformPropertyName("error")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Error => new TerraformReference(this, "error");

    /// <summary>
    /// The name of this migration job resource in the form of projects/{project}/locations/{location}/migrationJobs/{migrationJob}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The current migration job phase.
    /// </summary>
    [TerraformPropertyName("phase")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Phase => new TerraformReference(this, "phase");

    /// <summary>
    /// The current migration job state.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
