using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ec2_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncLocationEfsEc2ConfigBlock() : TerraformBlock("ec2_config")
{
    /// <summary>
    /// The security_group_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupArns is required")]
    [TerraformProperty("security_group_arns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SecurityGroupArns { get; set; }

    /// <summary>
    /// The subnet_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArn is required")]
    [TerraformProperty("subnet_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetArn { get; set; }

}

/// <summary>
/// Manages a aws_datasync_location_efs resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDatasyncLocationEfs : TerraformResource
{
    public AwsDatasyncLocationEfs(string name) : base("aws_datasync_location_efs", name)
    {
    }

    /// <summary>
    /// The access_point_arn attribute.
    /// </summary>
    [TerraformProperty("access_point_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessPointArn { get; set; }

    /// <summary>
    /// The efs_file_system_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EfsFileSystemArn is required")]
    [TerraformProperty("efs_file_system_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EfsFileSystemArn { get; set; }

    /// <summary>
    /// The file_system_access_role_arn attribute.
    /// </summary>
    [TerraformProperty("file_system_access_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileSystemAccessRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The in_transit_encryption attribute.
    /// </summary>
    [TerraformProperty("in_transit_encryption")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InTransitEncryption { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [TerraformProperty("subdirectory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subdirectory { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for ec2_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ec2Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ec2Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Config block(s) allowed")]
    [TerraformProperty("ec2_config")]
    public required TerraformList<AwsDatasyncLocationEfsEc2ConfigBlock> Ec2Config { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uri { get; }

}
