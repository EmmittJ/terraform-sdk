using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("thumbprint");
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public TerraformProperty<string>? AppServiceName
    {
        get => GetProperty<TerraformProperty<string>>("app_service_name");
        set => this.WithProperty("app_service_name", value);
    }

    /// <summary>
    /// The blob attribute.
    /// </summary>
    public TerraformProperty<string>? Blob
    {
        get => GetProperty<TerraformProperty<string>>("blob");
        set => this.WithProperty("blob", value);
    }

    /// <summary>
    /// The certificate_location attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateLocation
    {
        get => GetProperty<TerraformProperty<string>>("certificate_location");
        set => this.WithProperty("certificate_location", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateName
    {
        get => GetProperty<TerraformProperty<string>>("certificate_name");
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
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
