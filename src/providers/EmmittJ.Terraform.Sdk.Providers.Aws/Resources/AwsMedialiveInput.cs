using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destinations in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformProperty<string> StreamName
    {
        set => SetProperty("stream_name", value);
    }

}

/// <summary>
/// Block type for input_devices in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputInputDevicesBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

}

/// <summary>
/// Block type for media_connect_flows in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputMediaConnectFlowsBlock : TerraformBlock
{
    /// <summary>
    /// The flow_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FlowArn is required")]
    public required TerraformProperty<string> FlowArn
    {
        set => SetProperty("flow_arn", value);
    }

}

/// <summary>
/// Block type for sources in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveInputSourcesBlock : TerraformBlock
{
    /// <summary>
    /// The password_param attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PasswordParam is required")]
    public required TerraformProperty<string> PasswordParam
    {
        set => SetProperty("password_param", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMedialiveInputTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveInputVpcBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public List<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Manages a aws_medialive_input resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMedialiveInput : TerraformResource
{
    public AwsMedialiveInput(string name) : base("aws_medialive_input", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("attached_channels");
        SetOutput("input_class");
        SetOutput("input_partner_ids");
        SetOutput("input_source_type");
        SetOutput("id");
        SetOutput("input_security_groups");
        SetOutput("name");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The input_security_groups attribute.
    /// </summary>
    public List<TerraformProperty<string>> InputSecurityGroups
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("input_security_groups");
        set => SetProperty("input_security_groups", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsMedialiveInputDestinationsBlock>? Destinations
    {
        set => SetProperty("destinations", value);
    }

    /// <summary>
    /// Block for input_devices.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsMedialiveInputInputDevicesBlock>? InputDevices
    {
        set => SetProperty("input_devices", value);
    }

    /// <summary>
    /// Block for media_connect_flows.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsMedialiveInputMediaConnectFlowsBlock>? MediaConnectFlows
    {
        set => SetProperty("media_connect_flows", value);
    }

    /// <summary>
    /// Block for sources.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsMedialiveInputSourcesBlock>? Sources
    {
        set => SetProperty("sources", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMedialiveInputTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    public List<AwsMedialiveInputVpcBlock>? Vpc
    {
        set => SetProperty("vpc", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    public TerraformExpression AttachedChannels => this["attached_channels"];

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    public TerraformExpression InputClass => this["input_class"];

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    public TerraformExpression InputPartnerIds => this["input_partner_ids"];

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    public TerraformExpression InputSourceType => this["input_source_type"];

}
