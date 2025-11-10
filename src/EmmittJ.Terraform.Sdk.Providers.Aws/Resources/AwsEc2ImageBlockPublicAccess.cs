using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2ImageBlockPublicAccessTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_ec2_image_block_public_access resource.
/// </summary>
public class AwsEc2ImageBlockPublicAccess : TerraformResource
{
    public AwsEc2ImageBlockPublicAccess(string name) : base("aws_ec2_image_block_public_access", name)
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
    /// The state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2ImageBlockPublicAccessTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2ImageBlockPublicAccessTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
