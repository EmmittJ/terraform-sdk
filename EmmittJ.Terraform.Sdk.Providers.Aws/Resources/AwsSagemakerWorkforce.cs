using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_workforce resource.
/// </summary>
public class AwsSagemakerWorkforce : TerraformResource
{
    public AwsSagemakerWorkforce(string name) : base("aws_sagemaker_workforce", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("subdomain");
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
    /// The workforce_name attribute.
    /// </summary>
    public string? WorkforceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workforce_name")?.Value;
        set => this.WithProperty("workforce_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    public TerraformExpression Subdomain => this["subdomain"];

}
