using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubDpsCertificateTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_iothub_dps_certificate resource.
/// </summary>
public class AzurermIothubDpsCertificate : TerraformResource
{
    public AzurermIothubDpsCertificate(string name) : base("azurerm_iothub_dps_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("certificate_content");
        SetOutput("id");
        SetOutput("iot_dps_name");
        SetOutput("is_verified");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The certificate_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateContent is required")]
    public required TerraformProperty<string> CertificateContent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_content");
        set => SetProperty("certificate_content", value);
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
    /// The iot_dps_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IotDpsName is required")]
    public required TerraformProperty<string> IotDpsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iot_dps_name");
        set => SetProperty("iot_dps_name", value);
    }

    /// <summary>
    /// The is_verified attribute.
    /// </summary>
    public TerraformProperty<bool> IsVerified
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_verified");
        set => SetProperty("is_verified", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubDpsCertificateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
