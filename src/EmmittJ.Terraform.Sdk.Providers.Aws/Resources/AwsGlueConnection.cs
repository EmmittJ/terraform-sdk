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
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The security_group_id_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIdList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_id_list");
        set => WithProperty("security_group_id_list", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AthenaProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("athena_properties");
        set => this.WithProperty("athena_properties", value);
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ConnectionProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("connection_properties");
        set => this.WithProperty("connection_properties", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionType
    {
        get => GetProperty<TerraformProperty<string>>("connection_type");
        set => this.WithProperty("connection_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The match_criteria attribute.
    /// </summary>
    public List<TerraformProperty<string>>? MatchCriteria
    {
        get => GetProperty<List<TerraformProperty<string>>>("match_criteria");
        set => this.WithProperty("match_criteria", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for physical_connection_requirements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhysicalConnectionRequirements block(s) allowed")]
    public List<AwsGlueConnectionPhysicalConnectionRequirementsBlock>? PhysicalConnectionRequirements
    {
        get => GetProperty<List<AwsGlueConnectionPhysicalConnectionRequirementsBlock>>("physical_connection_requirements");
        set => this.WithProperty("physical_connection_requirements", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
