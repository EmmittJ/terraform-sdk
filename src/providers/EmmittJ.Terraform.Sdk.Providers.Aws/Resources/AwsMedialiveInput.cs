using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destinations in .
/// Nesting mode: set
/// </summary>
public partial class AwsMedialiveInputDestinationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    [TerraformProperty("stream_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamName { get; set; }

}

/// <summary>
/// Block type for input_devices in .
/// Nesting mode: set
/// </summary>
public partial class AwsMedialiveInputInputDevicesBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for media_connect_flows in .
/// Nesting mode: set
/// </summary>
public partial class AwsMedialiveInputMediaConnectFlowsBlock : TerraformBlockBase
{
    /// <summary>
    /// The flow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowArn is required")]
    [TerraformProperty("flow_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FlowArn { get; set; }

}

/// <summary>
/// Block type for sources in .
/// Nesting mode: set
/// </summary>
public partial class AwsMedialiveInputSourcesBlock : TerraformBlockBase
{
    /// <summary>
    /// The password_param attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordParam is required")]
    [TerraformProperty("password_param")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PasswordParam { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMedialiveInputTimeoutsBlock : TerraformBlockBase
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
/// Block type for vpc in .
/// Nesting mode: list
/// </summary>
public partial class AwsMedialiveInputVpcBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_medialive_input resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMedialiveInput : TerraformResource
{
    public AwsMedialiveInput(string name) : base("aws_medialive_input", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The input_security_groups attribute.
    /// </summary>
    [TerraformProperty("input_security_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? InputSecurityGroups { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoleArn { get; set; }

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("destinations")]
    public partial TerraformSet<TerraformBlock<AwsMedialiveInputDestinationsBlock>>? Destinations { get; set; }

    /// <summary>
    /// Block for input_devices.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("input_devices")]
    public partial TerraformSet<TerraformBlock<AwsMedialiveInputInputDevicesBlock>>? InputDevices { get; set; }

    /// <summary>
    /// Block for media_connect_flows.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("media_connect_flows")]
    public partial TerraformSet<TerraformBlock<AwsMedialiveInputMediaConnectFlowsBlock>>? MediaConnectFlows { get; set; }

    /// <summary>
    /// Block for sources.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("sources")]
    public partial TerraformSet<TerraformBlock<AwsMedialiveInputSourcesBlock>>? Sources { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsMedialiveInputTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    [TerraformProperty("vpc")]
    public partial TerraformList<TerraformBlock<AwsMedialiveInputVpcBlock>>? Vpc { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    [TerraformProperty("attached_channels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AttachedChannels { get; }

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    [TerraformProperty("input_class")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InputClass { get; }

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    [TerraformProperty("input_partner_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> InputPartnerIds { get; }

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    [TerraformProperty("input_source_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InputSourceType { get; }

}
