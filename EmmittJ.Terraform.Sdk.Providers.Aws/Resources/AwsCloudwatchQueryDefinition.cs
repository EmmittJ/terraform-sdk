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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_group_names attribute.
    /// </summary>
    public List<string>? LogGroupNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("log_group_names")?.Value;
        set => this.WithProperty("log_group_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_string attribute.
    /// </summary>
    public string? QueryString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query_string")?.Value;
        set => this.WithProperty("query_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The query_definition_id attribute.
    /// </summary>
    public TerraformExpression QueryDefinitionId => this["query_definition_id"];

}
