using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opsworks_permission resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsOpsworksPermission : TerraformResource
{
    public AwsOpsworksPermission(string name) : base("aws_opsworks_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allow_ssh attribute.
    /// </summary>
    public bool? AllowSsh
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_ssh")?.Value;
        set => this.WithProperty("allow_ssh", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allow_sudo attribute.
    /// </summary>
    public bool? AllowSudo
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_sudo")?.Value;
        set => this.WithProperty("allow_sudo", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The level attribute.
    /// </summary>
    public string? Level
    {
        get => GetProperty<TerraformLiteralProperty<string>>("level")?.Value;
        set => this.WithProperty("level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    public string? StackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_id")?.Value;
        set => this.WithProperty("stack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_arn attribute.
    /// </summary>
    public string? UserArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_arn")?.Value;
        set => this.WithProperty("user_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
