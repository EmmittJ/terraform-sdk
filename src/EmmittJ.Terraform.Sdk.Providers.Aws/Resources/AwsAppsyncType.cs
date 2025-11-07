using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appsync_type resource.
/// </summary>
public class AwsAppsyncType : TerraformResource
{
    public AwsAppsyncType(string name) : base("aws_appsync_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("description");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_id");
        set => this.WithProperty("api_id", value);
    }

    /// <summary>
    /// The definition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Definition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("definition");
        set => this.WithProperty("definition", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Format
    {
        get => GetProperty<TerraformLiteralProperty<string>>("format");
        set => this.WithProperty("format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
