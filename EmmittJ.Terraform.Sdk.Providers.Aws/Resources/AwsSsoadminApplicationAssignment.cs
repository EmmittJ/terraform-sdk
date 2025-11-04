using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_application_assignment resource.
/// </summary>
public class AwsSsoadminApplicationAssignment : TerraformResource
{
    public AwsSsoadminApplicationAssignment(string name) : base("aws_ssoadmin_application_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public string? ApplicationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_arn")?.Value;
        set => this.WithProperty("application_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public string? PrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_id")?.Value;
        set => this.WithProperty("principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_type attribute.
    /// </summary>
    public string? PrincipalType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_type")?.Value;
        set => this.WithProperty("principal_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
