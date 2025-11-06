using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_deployment resource.
/// </summary>
public class AwsApiGatewayDeployment : TerraformResource
{
    public AwsApiGatewayDeployment(string name) : base("aws_api_gateway_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_date");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    public string? RestApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rest_api_id")?.Value;
        set => this.WithProperty("rest_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, string>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers")?.Value;
        set => this.WithProperty("triggers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The variables attribute.
    /// </summary>
    public Dictionary<string, string>? Variables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("variables")?.Value;
        set => this.WithProperty("variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

}
