using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target in .
/// Nesting mode: list
/// </summary>
public class AwsVpclatticeTargetGroupAttachmentTargetBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpclatticeTargetGroupAttachmentTimeoutsBlock : TerraformBlock
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
/// Manages a aws_vpclattice_target_group_attachment resource.
/// </summary>
public class AwsVpclatticeTargetGroupAttachment : TerraformResource
{
    public AwsVpclatticeTargetGroupAttachment(string name) : base("aws_vpclattice_target_group_attachment", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The target_group_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupIdentifier is required")]
    public required TerraformProperty<string> TargetGroupIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("target_group_identifier");
        set => this.WithProperty("target_group_identifier", value);
    }

    /// <summary>
    /// Block for target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public List<AwsVpclatticeTargetGroupAttachmentTargetBlock>? Target
    {
        get => GetProperty<List<AwsVpclatticeTargetGroupAttachmentTargetBlock>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpclatticeTargetGroupAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpclatticeTargetGroupAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
