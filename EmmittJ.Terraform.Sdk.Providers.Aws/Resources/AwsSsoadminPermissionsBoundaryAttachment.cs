using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_permissions_boundary_attachment resource.
/// </summary>
public class AwsSsoadminPermissionsBoundaryAttachment : TerraformResource
{
    public AwsSsoadminPermissionsBoundaryAttachment(string name) : base("aws_ssoadmin_permissions_boundary_attachment", name)
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

}
