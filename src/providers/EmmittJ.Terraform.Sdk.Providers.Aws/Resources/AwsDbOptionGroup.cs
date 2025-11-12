using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for option in .
/// Nesting mode: set
/// </summary>
public partial class AwsDbOptionGroupOptionBlock() : TerraformBlock("option")
{
    /// <summary>
    /// The db_security_group_memberships attribute.
    /// </summary>
    [TerraformProperty("db_security_group_memberships")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DbSecurityGroupMemberships { get; set; }

    /// <summary>
    /// The option_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptionName is required")]
    [TerraformProperty("option_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OptionName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The vpc_security_group_memberships attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_memberships")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? VpcSecurityGroupMemberships { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDbOptionGroupTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_db_option_group resource.
/// </summary>
public partial class AwsDbOptionGroup : TerraformResource
{
    public AwsDbOptionGroup(string name) : base("aws_db_option_group", name)
    {
    }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    [TerraformProperty("engine_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MajorEngineVersion is required")]
    [TerraformProperty("major_engine_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MajorEngineVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The option_group_description attribute.
    /// </summary>
    [TerraformProperty("option_group_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OptionGroupDescription { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipDestroy { get; set; }

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
    /// Block for option.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("option")]
    public TerraformSet<AwsDbOptionGroupOptionBlock> Option { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDbOptionGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
