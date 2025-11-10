using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServicePublicCertificateTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_app_service_public_certificate resource.
/// </summary>
public class AzurermAppServicePublicCertificate : TerraformResource
{
    public AzurermAppServicePublicCertificate(string name) : base("azurerm_app_service_public_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("thumbprint");
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    public required TerraformProperty<string> AppServiceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app_service_name");
        set => this.WithProperty("app_service_name", value);
    }

    /// <summary>
    /// The blob attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Blob is required")]
    public required TerraformProperty<string> Blob
    {
        get => GetRequiredProperty<TerraformProperty<string>>("blob");
        set => this.WithProperty("blob", value);
    }

    /// <summary>
    /// The certificate_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateLocation is required")]
    public required TerraformProperty<string> CertificateLocation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("certificate_location");
        set => this.WithProperty("certificate_location", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateName is required")]
    public required TerraformProperty<string> CertificateName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("certificate_name");
        set => this.WithProperty("certificate_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServicePublicCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServicePublicCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
