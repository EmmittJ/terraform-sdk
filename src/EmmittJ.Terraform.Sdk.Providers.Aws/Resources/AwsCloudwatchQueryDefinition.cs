using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_query_definition resource.
/// </summary>
public class AwsCloudwatchQueryDefinition : TerraformResource
{
    public AwsCloudwatchQueryDefinition(string name) : base("aws_cloudwatch_query_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("query_definition_id");
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
    /// The log_group_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LogGroupNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("log_group_names");
        set => this.WithProperty("log_group_names", value);
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
    /// The query_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryString is required")]
    public required TerraformProperty<string> QueryString
    {
        get => GetProperty<TerraformProperty<string>>("query_string");
        set => this.WithProperty("query_string", value);
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
    /// The query_definition_id attribute.
    /// </summary>
    public TerraformExpression QueryDefinitionId => this["query_definition_id"];

}
