using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSsoadminManagedPolicyAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_ssoadmin_managed_policy_attachment resource.
/// </summary>
public class AwsSsoadminManagedPolicyAttachment : TerraformResource
{
    public AwsSsoadminManagedPolicyAttachment(string name) : base("aws_ssoadmin_managed_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("managed_policy_name");
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
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformProperty<string> InstanceArn
    {
        get => GetProperty<TerraformProperty<string>>("instance_arn");
        set => this.WithProperty("instance_arn", value);
    }

    /// <summary>
    /// The managed_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedPolicyArn is required")]
    public required TerraformProperty<string> ManagedPolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("managed_policy_arn");
        set => this.WithProperty("managed_policy_arn", value);
    }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionSetArn is required")]
    public required TerraformProperty<string> PermissionSetArn
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

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSsoadminManagedPolicyAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsSsoadminManagedPolicyAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The managed_policy_name attribute.
    /// </summary>
    public TerraformExpression ManagedPolicyName => this["managed_policy_name"];

}
