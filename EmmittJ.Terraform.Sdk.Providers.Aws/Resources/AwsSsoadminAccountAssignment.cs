using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_account_assignment resource.
/// </summary>
public class AwsSsoadminAccountAssignment : TerraformResource
{
    public AwsSsoadminAccountAssignment(string name) : base("aws_ssoadmin_account_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The instance_arn attribute.
    /// </summary>
    public string? InstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_arn")?.Value;
        set => this.WithProperty("instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    public string? PermissionSetArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permission_set_arn")?.Value;
        set => this.WithProperty("permission_set_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The target_id attribute.
    /// </summary>
    public string? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id")?.Value;
        set => this.WithProperty("target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public string? TargetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_type")?.Value;
        set => this.WithProperty("target_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
