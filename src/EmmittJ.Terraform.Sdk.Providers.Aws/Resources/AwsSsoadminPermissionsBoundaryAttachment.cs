using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for permissions_boundary in .
/// Nesting mode: list
/// </summary>
public class AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock : TerraformBlock
{
    /// <summary>
    /// The managed_policy_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedPolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("managed_policy_arn");
        set => WithProperty("managed_policy_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSsoadminPermissionsBoundaryAttachmentTimeoutsBlock : TerraformBlock
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
/// Manages a aws_ssoadmin_permissions_boundary_attachment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    /// Block for permissions_boundary.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PermissionsBoundary block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PermissionsBoundary block(s) allowed")]
    public List<AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock>? PermissionsBoundary
    {
        get => GetProperty<List<AwsSsoadminPermissionsBoundaryAttachmentPermissionsBoundaryBlock>>("permissions_boundary");
        set => this.WithProperty("permissions_boundary", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSsoadminPermissionsBoundaryAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsSsoadminPermissionsBoundaryAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
