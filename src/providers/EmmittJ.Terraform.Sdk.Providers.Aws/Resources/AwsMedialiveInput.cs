using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destinations in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputDestinationsBlock
{
    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    [TerraformPropertyName("stream_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StreamName { get; set; }

}

/// <summary>
/// Block type for input_devices in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputInputDevicesBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for media_connect_flows in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputMediaConnectFlowsBlock
{
    /// <summary>
    /// The flow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowArn is required")]
    [TerraformPropertyName("flow_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FlowArn { get; set; }

}

/// <summary>
/// Block type for sources in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputSourcesBlock
{
    /// <summary>
    /// The password_param attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordParam is required")]
    [TerraformPropertyName("password_param")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PasswordParam { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Url { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMedialiveInputTimeoutsBlock
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
/// Block type for vpc in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveInputVpcBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_medialive_input resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMedialiveInput : TerraformResource
{
    public AwsMedialiveInput(string name) : base("aws_medialive_input", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The input_security_groups attribute.
    /// </summary>
    [TerraformPropertyName("input_security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? InputSecurityGroups { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoleArn { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("destinations")]
    public TerraformSet<TerraformBlock<AwsMedialiveInputDestinationsBlock>>? Destinations { get; set; }

    /// <summary>
    /// Block for input_devices.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("input_devices")]
    public TerraformSet<TerraformBlock<AwsMedialiveInputInputDevicesBlock>>? InputDevices { get; set; }

    /// <summary>
    /// Block for media_connect_flows.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("media_connect_flows")]
    public TerraformSet<TerraformBlock<AwsMedialiveInputMediaConnectFlowsBlock>>? MediaConnectFlows { get; set; }

    /// <summary>
    /// Block for sources.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("sources")]
    public TerraformSet<TerraformBlock<AwsMedialiveInputSourcesBlock>>? Sources { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMedialiveInputTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    [TerraformPropertyName("vpc")]
    public TerraformList<TerraformBlock<AwsMedialiveInputVpcBlock>>? Vpc { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    [TerraformPropertyName("attached_channels")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AttachedChannels => new TerraformReference(this, "attached_channels");

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    [TerraformPropertyName("input_class")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InputClass => new TerraformReference(this, "input_class");

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    [TerraformPropertyName("input_partner_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InputPartnerIds => new TerraformReference(this, "input_partner_ids");

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    [TerraformPropertyName("input_source_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InputSourceType => new TerraformReference(this, "input_source_type");

}
