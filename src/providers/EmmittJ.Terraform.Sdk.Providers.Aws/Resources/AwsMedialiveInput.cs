using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destinations in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputDestinationsBlock : ITerraformBlock
{
    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    [TerraformPropertyName("stream_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StreamName { get; set; }

}

/// <summary>
/// Block type for input_devices in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputInputDevicesBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

}

/// <summary>
/// Block type for media_connect_flows in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputMediaConnectFlowsBlock : ITerraformBlock
{
    /// <summary>
    /// The flow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowArn is required")]
    [TerraformPropertyName("flow_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FlowArn { get; set; }

}

/// <summary>
/// Block type for sources in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputSourcesBlock : ITerraformBlock
{
    /// <summary>
    /// The password_param attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordParam is required")]
    [TerraformPropertyName("password_param")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PasswordParam { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMedialiveInputTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vpc in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveInputVpcBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? SubnetIds { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The input_security_groups attribute.
    /// </summary>
    [TerraformPropertyName("input_security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? InputSecurityGroups { get; set; }

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
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_arn");

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("destinations")]
    public TerraformSet<TerraformBlock<AwsMedialiveInputDestinationsBlock>>? Destinations { get; set; } = new();

    /// <summary>
    /// Block for input_devices.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("input_devices")]
    public TerraformSet<TerraformBlock<AwsMedialiveInputInputDevicesBlock>>? InputDevices { get; set; } = new();

    /// <summary>
    /// Block for media_connect_flows.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("media_connect_flows")]
    public TerraformSet<TerraformBlock<AwsMedialiveInputMediaConnectFlowsBlock>>? MediaConnectFlows { get; set; } = new();

    /// <summary>
    /// Block for sources.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("sources")]
    public TerraformSet<TerraformBlock<AwsMedialiveInputSourcesBlock>>? Sources { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMedialiveInputTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    [TerraformPropertyName("vpc")]
    public TerraformList<TerraformBlock<AwsMedialiveInputVpcBlock>>? Vpc { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    [TerraformPropertyName("attached_channels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AttachedChannels => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "attached_channels");

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    [TerraformPropertyName("input_class")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InputClass => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "input_class");

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    [TerraformPropertyName("input_partner_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InputPartnerIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "input_partner_ids");

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    [TerraformPropertyName("input_source_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InputSourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "input_source_type");

}
