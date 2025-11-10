using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for option in .
/// Nesting mode: set
/// </summary>
public class AwsDbOptionGroupOptionBlock : TerraformBlock
{
    /// <summary>
    /// The db_security_group_memberships attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DbSecurityGroupMemberships
    {
        set => SetProperty("db_security_group_memberships", value);
    }

    /// <summary>
    /// The option_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptionName is required")]
    public required TerraformProperty<string> OptionName
    {
        set => SetProperty("option_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The vpc_security_group_memberships attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupMemberships
    {
        set => SetProperty("vpc_security_group_memberships", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbOptionGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_db_option_group resource.
/// </summary>
public class AwsDbOptionGroup : TerraformResource
{
    public AwsDbOptionGroup(string name) : base("aws_db_option_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("engine_name");
        SetOutput("id");
        SetOutput("major_engine_version");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("option_group_description");
        SetOutput("region");
        SetOutput("skip_destroy");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    public required TerraformProperty<string> EngineName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_name");
        set => SetProperty("engine_name", value);
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
    /// The major_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MajorEngineVersion is required")]
    public required TerraformProperty<string> MajorEngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("major_engine_version");
        set => SetProperty("major_engine_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The option_group_description attribute.
    /// </summary>
    public TerraformProperty<string> OptionGroupDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("option_group_description");
        set => SetProperty("option_group_description", value);
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
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
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
    /// Block for option.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDbOptionGroupOptionBlock>? Option
    {
        set => SetProperty("option", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbOptionGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
