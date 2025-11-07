using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssoadmin_permission_set_inline_policy resource.
/// </summary>
public class AwsSsoadminPermissionSetInlinePolicy : TerraformResource
{
    public AwsSsoadminPermissionSetInlinePolicy(string name) : base("aws_ssoadmin_permission_set_inline_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The inline_policy attribute.
    /// </summary>
    public TerraformProperty<string>? InlinePolicy
    {
        get => GetProperty<TerraformProperty<string>>("inline_policy");
        set => this.WithProperty("inline_policy", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceArn
    {
        get => GetProperty<TerraformProperty<string>>("instance_arn");
        set => this.WithProperty("instance_arn", value);
    }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    public TerraformProperty<string>? PermissionSetArn
    {
        get => GetProperty<TerraformProperty<string>>("permission_set_arn");
        set => this.WithProperty("permission_set_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
