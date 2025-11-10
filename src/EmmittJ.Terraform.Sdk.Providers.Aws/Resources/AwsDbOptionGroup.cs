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
        get => GetProperty<HashSet<TerraformProperty<string>>>("db_security_group_memberships");
        set => WithProperty("db_security_group_memberships", value);
    }

    /// <summary>
    /// The option_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OptionName is required")]
    public required TerraformProperty<string> OptionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("option_name");
        set => WithProperty("option_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

    /// <summary>
    /// The vpc_security_group_memberships attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupMemberships
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_memberships");
        set => WithProperty("vpc_security_group_memberships", value);
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
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The engine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineName is required")]
    public required TerraformProperty<string> EngineName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine_name");
        set => this.WithProperty("engine_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MajorEngineVersion is required")]
    public required TerraformProperty<string> MajorEngineVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("major_engine_version");
        set => this.WithProperty("major_engine_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The option_group_description attribute.
    /// </summary>
    public TerraformProperty<string>? OptionGroupDescription
    {
        get => GetProperty<TerraformProperty<string>>("option_group_description");
        set => this.WithProperty("option_group_description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for option.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDbOptionGroupOptionBlock>? Option
    {
        get => GetProperty<HashSet<AwsDbOptionGroupOptionBlock>>("option");
        set => this.WithProperty("option", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbOptionGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDbOptionGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
