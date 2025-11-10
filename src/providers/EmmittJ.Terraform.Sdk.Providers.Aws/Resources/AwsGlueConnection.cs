using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for physical_connection_requirements in .
/// Nesting mode: list
/// </summary>
public class AwsGlueConnectionPhysicalConnectionRequirementsBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The security_group_id_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIdList
    {
        set => SetProperty("security_group_id_list", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Manages a aws_glue_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueConnection : TerraformResource
{
    public AwsGlueConnection(string name) : base("aws_glue_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("athena_properties");
        SetOutput("catalog_id");
        SetOutput("connection_properties");
        SetOutput("connection_type");
        SetOutput("description");
        SetOutput("id");
        SetOutput("match_criteria");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AthenaProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("athena_properties");
        set => SetProperty("athena_properties", value);
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ConnectionProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("connection_properties");
        set => SetProperty("connection_properties", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_type");
        set => SetProperty("connection_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The match_criteria attribute.
    /// </summary>
    public List<TerraformProperty<string>> MatchCriteria
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("match_criteria");
        set => SetProperty("match_criteria", value);
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
    /// Block for physical_connection_requirements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhysicalConnectionRequirements block(s) allowed")]
    public List<AwsGlueConnectionPhysicalConnectionRequirementsBlock>? PhysicalConnectionRequirements
    {
        set => SetProperty("physical_connection_requirements", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
