using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_application_assignment_configuration resource.
/// </summary>
public class AwsSsoadminApplicationAssignmentConfiguration : TerraformResource
{
    public AwsSsoadminApplicationAssignmentConfiguration(string name) : base("aws_ssoadmin_application_assignment_configuration", name)
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
    /// The assignment_required attribute.
    /// </summary>
    public bool? AssignmentRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("assignment_required")?.Value;
        set => this.WithProperty("assignment_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
