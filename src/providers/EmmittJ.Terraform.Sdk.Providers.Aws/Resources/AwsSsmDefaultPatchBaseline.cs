using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_default_patch_baseline resource.
/// </summary>
public class AwsSsmDefaultPatchBaseline : TerraformResource
{
    public AwsSsmDefaultPatchBaseline(string name) : base("aws_ssm_default_patch_baseline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("baseline_id");
        SetOutput("id");
        SetOutput("operating_system");
        SetOutput("region");
    }

    /// <summary>
    /// The baseline_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaselineId is required")]
    public required TerraformProperty<string> BaselineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("baseline_id");
        set => SetProperty("baseline_id", value);
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
    /// The operating_system attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingSystem is required")]
    public required TerraformProperty<string> OperatingSystem
    {
        get => GetRequiredOutput<TerraformProperty<string>>("operating_system");
        set => SetProperty("operating_system", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
