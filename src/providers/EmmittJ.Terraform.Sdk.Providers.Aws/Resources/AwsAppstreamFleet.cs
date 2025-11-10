using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetComputeCapacityBlock : ITerraformBlock
{
    /// <summary>
    /// The available attribute.
    /// </summary>
    [TerraformPropertyName("available")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Available => new TerraformReferenceProperty<TerraformProperty<double>>("", "available");

    /// <summary>
    /// The desired_instances attribute.
    /// </summary>
    [TerraformPropertyName("desired_instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DesiredInstances { get; set; }

    /// <summary>
    /// The desired_sessions attribute.
    /// </summary>
    [TerraformPropertyName("desired_sessions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DesiredSessions { get; set; }

    /// <summary>
    /// The in_use attribute.
    /// </summary>
    [TerraformPropertyName("in_use")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InUse => new TerraformReferenceProperty<TerraformProperty<double>>("", "in_use");

    /// <summary>
    /// The running attribute.
    /// </summary>
    [TerraformPropertyName("running")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Running => new TerraformReferenceProperty<TerraformProperty<double>>("", "running");

}

/// <summary>
/// Block type for domain_join_info in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetDomainJoinInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The directory_name attribute.
    /// </summary>
    [TerraformPropertyName("directory_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DirectoryName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "directory_name");

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit_distinguished_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OrganizationalUnitDistinguishedName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "organizational_unit_distinguished_name");

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamFleetVpcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> SecurityGroupIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "security_group_ids");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> SubnetIds { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "subnet_ids");

}

/// <summary>
/// Manages a aws_appstream_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppstreamFleet : TerraformResource
{
    public AwsAppstreamFleet(string name) : base("aws_appstream_fleet", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Description { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The disconnect_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("disconnect_timeout_in_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DisconnectTimeoutInSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "disconnect_timeout_in_seconds");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The enable_default_internet_access attribute.
    /// </summary>
    [TerraformPropertyName("enable_default_internet_access")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableDefaultInternetAccess { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_default_internet_access");

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    [TerraformPropertyName("fleet_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FleetType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fleet_type");

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IamRoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_role_arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The idle_disconnect_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("idle_disconnect_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IdleDisconnectTimeoutInSeconds { get; set; }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    [TerraformPropertyName("image_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ImageArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_arn");

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [TerraformPropertyName("image_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ImageName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_name");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceType { get; set; }

    /// <summary>
    /// The max_sessions_per_instance attribute.
    /// </summary>
    [TerraformPropertyName("max_sessions_per_instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxSessionsPerInstance { get; set; }

    /// <summary>
    /// The max_user_duration_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("max_user_duration_in_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxUserDurationInSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_user_duration_in_seconds");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The stream_view attribute.
    /// </summary>
    [TerraformPropertyName("stream_view")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StreamView { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stream_view");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for compute_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCapacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeCapacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeCapacity block(s) allowed")]
    [TerraformPropertyName("compute_capacity")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetComputeCapacityBlock>>? ComputeCapacity { get; set; } = new();

    /// <summary>
    /// Block for domain_join_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainJoinInfo block(s) allowed")]
    [TerraformPropertyName("domain_join_info")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetDomainJoinInfoBlock>>? DomainJoinInfo { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsAppstreamFleetVpcConfigBlock>>? VpcConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
