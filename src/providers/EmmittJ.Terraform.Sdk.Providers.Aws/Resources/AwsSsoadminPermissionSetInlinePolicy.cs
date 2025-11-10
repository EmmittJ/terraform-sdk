using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSsoadminPermissionSetInlinePolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

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
        SetOutput("id");
        SetOutput("inline_policy");
        SetOutput("instance_arn");
        SetOutput("permission_set_arn");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The inline_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InlinePolicy is required")]
    public required TerraformProperty<string> InlinePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("inline_policy");
        set => SetProperty("inline_policy", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformProperty<string> InstanceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_arn");
        set => SetProperty("instance_arn", value);
    }

    /// <summary>
    /// The permission_set_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionSetArn is required")]
    public required TerraformProperty<string> PermissionSetArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("permission_set_arn");
        set => SetProperty("permission_set_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSsoadminPermissionSetInlinePolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
