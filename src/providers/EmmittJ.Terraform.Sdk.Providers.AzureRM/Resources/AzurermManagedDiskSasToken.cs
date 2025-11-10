using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskSasTokenTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_managed_disk_sas_token resource.
/// </summary>
public class AzurermManagedDiskSasToken : TerraformResource
{
    public AzurermManagedDiskSasToken(string name) : base("azurerm_managed_disk_sas_token", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("sas_url");
        SetOutput("access_level");
        SetOutput("duration_in_seconds");
        SetOutput("id");
        SetOutput("managed_disk_id");
    }

    /// <summary>
    /// The access_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLevel is required")]
    public required TerraformProperty<string> AccessLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_level");
        set => SetProperty("access_level", value);
    }

    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DurationInSeconds is required")]
    public required TerraformProperty<double> DurationInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("duration_in_seconds");
        set => SetProperty("duration_in_seconds", value);
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
    /// The managed_disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedDiskId is required")]
    public required TerraformProperty<string> ManagedDiskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_disk_id");
        set => SetProperty("managed_disk_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedDiskSasTokenTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    public TerraformExpression SasUrl => this["sas_url"];

}
