using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for datasources in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsGuarddutyOrganizationConfigurationDatasourcesBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_guardduty_organization_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGuarddutyOrganizationConfiguration : TerraformResource
{
    public AwsGuarddutyOrganizationConfiguration(string name) : base("aws_guardduty_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_enable_organization_members");
        SetOutput("detector_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The auto_enable_organization_members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoEnableOrganizationMembers is required")]
    public required TerraformProperty<string> AutoEnableOrganizationMembers
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_enable_organization_members");
        set => SetProperty("auto_enable_organization_members", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformProperty<string> DetectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("detector_id");
        set => SetProperty("detector_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for datasources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datasources block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsGuarddutyOrganizationConfigurationDatasourcesBlock>? Datasources
    {
        set => SetProperty("datasources", value);
    }

}
